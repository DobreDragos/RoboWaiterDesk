using System;
using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using RoboDesk.Forms.Base;
using RoboDesk.Interfaces;
using RoboDesk.Utils;
using DataLayerStandard.DataEntities;
using DataLayerHelper.Classes;
using VIBlend.WinForms.Controls;
using System.Collections.Generic;
using DataLayerHelper.Enums;
using System.Linq;

namespace RoboDesk
{
    public class ProductsPresenter : CrudPresenterBase<IProductsFrm, Products>
    {
        Dictionary<long, Dictionary<long, string>> ProductIdToNamesByLanguageDictionary;
        public ProductsPresenter(IProductsFrm view) : base(view)
        {
            ProductIdToNamesByLanguageDictionary = new Dictionary<long, Dictionary<long, string>>();
            RefreshTranslations(ObjectTypeId.Products);

        }

        public string GetNameBySelectedLanguage(long languageId)
        {
            string name = "";
            var id = SelectedModel?.Id;
            if (id.HasValue && ProductIdToNamesByLanguageDictionary.TryGetValue(id.Value, out Dictionary<long, string> nameByLang))
                nameByLang.TryGetValue(languageId, out name);
            return name;
        }

        private void RefreshTranslations(ObjectTypeId type)
        {
            ProductIdToNamesByLanguageDictionary = new Dictionary<long, Dictionary<long, string>>();
            var names = Context.Get<INamesDE>().GetAllFromDb(new SqlFilter("ObjectTypeId", (int)type, SqlOperators.equals));
            var langs = Context.Get<ILanguagesDE>().GetAll();

            foreach (var groupedByProductId in names.GroupBy(x => x.ObjectId))
            {
                Dictionary<long, string> namesByLanguage = new Dictionary<long, string>();
                foreach (var groupedByLanguage in groupedByProductId.ToList().GroupBy(x => x.LanguageId))
                {
                    namesByLanguage.Add(groupedByLanguage.Key, groupedByLanguage.FirstOrDefault()?.Name);
                }
                ProductIdToNamesByLanguageDictionary.Add(groupedByProductId.Key, namesByLanguage);
            }
        }

        public override IDgvDbAccess DbAccess => Context.Get<IProductsDE>();

        protected override void ExecuteDeleteDb(Products model)
        {
            ((IProductsDE)DbAccess).Delete(model);
            Context.Get<INamesDE>().DeleteAll("ObjectId", model.Id);
            RefreshTranslations(ObjectTypeId.Products);
        }

        protected override void ExecuteInsertDb(Products model)
        {
            ((IProductsDE)DbAccess).Insert(model);
            UpdateNames(model);
            RefreshTranslations(ObjectTypeId.Products);
        }

        private static void UpdateNames(Products model)
        {
            var names = Context.Get<INamesDE>().GetAllFromDb(new SqlFilter("ObjectTypeId", (int)ObjectTypeId.Products, SqlOperators.equals));
            foreach (var langId in model.LangToName.Keys)
            {
                var name = names.FirstOrDefault(x => x.LanguageId == langId && x.ObjectId == model.Id) ?? new Names { LanguageId = langId, ObjectId = model.Id, ObjectTypeId = (int)ObjectTypeId.Products };
                name.Name = model.LangToName[langId];

                if (name.Id > 0)
                    Context.Get<INamesDE>().Update(name);
                else
                    Context.Get<INamesDE>().Insert(name);

            }
        }

        protected override void ExecuteUpdateDb(Products model)
        {
            ((IProductsDE)DbAccess).Update(model);
            UpdateNames(model);
            RefreshTranslations(ObjectTypeId.Products);
        }

        internal void EnsureLanguages(vComboBox cb)
        {
            var langs = Context.Get<ILanguagesDE>().GetAll();
            cb.DisplayMember = "Value";
            cb.ValueMember = "Id";
            cb.DataSource = langs;
        }

        internal void EnsureFamilies(vComboBox cb)
        {
            var families = Context.Get<IFamiliesDE>().GetAll();
            cb.DisplayMember = "Code";
            cb.ValueMember = "Id";
            cb.DataSource = families;
        }

        protected override object GetGridPage(int pageOffset, int maxRecords)
        {
            var products = base.GetGridPage(pageOffset, maxRecords);

            foreach (var product in products as List<Products>)
            {
                product.LangToName = ProductIdToNamesByLanguageDictionary.ContainsKey(product.Id)?
                    ProductIdToNamesByLanguageDictionary[product.Id] : new Dictionary<long, string>();
            }

            return products;
        }
    }
}
