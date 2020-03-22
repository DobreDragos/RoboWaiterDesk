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
using BusinessLayerStandard.Extensions;

namespace RoboDesk
{
    public class MenusPresenter : CrudPresenterBase<IMenusFrm, Menus>
    {
        private const ObjectTypeId ObjectTypeName = ObjectTypeId.Menus_Name;
        private const ObjectTypeId ObjectTypeDescription = ObjectTypeId.Menus_Description;
        public MenusPresenter(IMenusFrm view) : base(view)
        {
            RefreshTranslations();
        }

        private void RefreshTranslations()
        {
            ModelIdToNamesByLanguageDictionary = Context.GetTranslations(ObjectTypeName);
            ModelIdToDescriptionByLanguageDictionary = Context.GetTranslations(ObjectTypeDescription);
        }

        public override IDgvDbAccess DbAccess => Context.Get<IMenusDE>();

        public Dictionary<long, Dictionary<long, string>> ModelIdToNamesByLanguageDictionary;
        public Dictionary<long, Dictionary<long, string>> ModelIdToDescriptionByLanguageDictionary;

        protected override void ExecuteDeleteDb(Menus model)
        {
            ((IMenusDE)DbAccess).Delete(model);
            Context.DeleteTranslations(model.Id, ObjectTypeName);
            Context.DeleteTranslations(model.Id, ObjectTypeDescription);
            RefreshTranslations();
        }

        protected override void ExecuteInsertDb(Menus model)
        {
            var id = ((IMenusDE)DbAccess).Insert(model);
            Context.UpdateTranslations(id, ObjectTypeName, model.LangToName);
            Context.UpdateTranslations(id, ObjectTypeDescription, model.LangToDescription);

            RefreshTranslations();
        }

        protected override void ExecuteUpdateDb(Menus model)
        {
            ((IMenusDE)DbAccess).Update(model);
            Context.UpdateTranslations(model.Id, ObjectTypeName, model.LangToName);
            Context.UpdateTranslations(model.Id, ObjectTypeDescription, model.LangToDescription);
            RefreshTranslations();
        }

        internal void EnsureLanguages(vComboBox cb)
        {
            var langs = Context.Get<ILanguagesDE>().GetAll();
            cb.DisplayMember = "Value";
            cb.ValueMember = "Id";
            cb.DataSource = langs;
        }

        internal string GetNameBySelectedLanguage(long lang, long selectedId)
        {
            string name = "";
            if (ModelIdToNamesByLanguageDictionary.TryGetValue(selectedId, out Dictionary<long, string> nameByLang))
                nameByLang.TryGetValue(lang, out name);
            return name;
        }

        internal string GetDescriptionBySelectedLanguage(long lang, long selectedId)
        {
            string description = "";
            if (ModelIdToDescriptionByLanguageDictionary.TryGetValue(selectedId, out Dictionary<long, string> val))
                val.TryGetValue(lang, out description);
            return description;
        }

        protected override object GetGridPage(int pageOffset, int maxRecords)
        {
            var products = base.GetGridPage(pageOffset, maxRecords);

            foreach (var product in products as List<Menus>)
            {
                product.LangToName = ModelIdToNamesByLanguageDictionary.ContainsKey(product.Id) ?
                    ModelIdToNamesByLanguageDictionary[product.Id] : new Dictionary<long, string>();
                product.LangToName = ModelIdToDescriptionByLanguageDictionary.ContainsKey(product.Id) ?
                    ModelIdToNamesByLanguageDictionary[product.Id] : new Dictionary<long, string>();

            }

            return products;
        }
    }
}
