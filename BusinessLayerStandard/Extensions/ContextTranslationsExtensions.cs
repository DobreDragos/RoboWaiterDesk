﻿using BusinessLayer;
using DataLayerHelper.Classes;
using DataLayerHelper.Enums;
using DataLayerStandard.DataEntities;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayerStandard.Extensions
{
    public static class ContextTranslationsExtensions
    {
        public static Dictionary<long, Dictionary<long, string>> GetTranslations(this IContext Context, ObjectTypeId type)
        {
            var modelIdToNamesByLanguageDictionary = new Dictionary<long, Dictionary<long, string>>();
            var names = Context.Get<ITranslationsDE>().GetAllFromDb(new SqlFilter("ObjectTypeId", (int)type, SqlOperators.equals));
            var langs = Context.Get<ILanguagesDE>().GetAll();

            foreach (var groupedByProductId in names.GroupBy(x => x.ObjectId))
            {
                var namesByLanguage = new Dictionary<long, string>();
                foreach (var groupedByLanguage in groupedByProductId.ToList().GroupBy(x => x.LanguageId))
                {
                    namesByLanguage.Add(groupedByLanguage.Key, groupedByLanguage.FirstOrDefault()?.Name);
                }
                modelIdToNamesByLanguageDictionary.Add(groupedByProductId.Key, namesByLanguage);
            }

            return modelIdToNamesByLanguageDictionary;
        }

        public static void UpdateTranslations(this IContext context, long modelId, ObjectTypeId objectType,Dictionary<long,string> langToName)
        {
            var names = context.Get<ITranslationsDE>().GetAllFromDb(new SqlFilter("ObjectTypeId", (int)objectType));
            foreach (var langId in langToName.Keys)
            {
                var name = names.FirstOrDefault(x => x.LanguageId == langId && x.ObjectId == modelId)
                    ?? new Translations { LanguageId = langId, ObjectId = modelId, ObjectTypeId = (int)objectType };
                name.Name = langToName[langId];

                if (name.Id > 0)
                    context.Get<ITranslationsDE>().Update(name);
                else
                    context.Get<ITranslationsDE>().Insert(name);

            }
        }

        public static void DeleteTranslations(this IContext context, long modelId, ObjectTypeId objectType)
        {
            context.Get<ITranslationsDE>().DeleteAllFromDb(
                new SqlFilter("ObjectTypeId", (int)objectType, SqlOperators.equals, SqlLogicOperators.and),
                new SqlFilter("ObjectId", modelId));
        }
        }
}
