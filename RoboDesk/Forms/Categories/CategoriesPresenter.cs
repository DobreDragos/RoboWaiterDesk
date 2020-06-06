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
using RoboDesk.Interfaces.Categories;

namespace RoboDesk
{
    public class CategoriesPresenter : CrudPresenterBase<ICategoriesFrm, Families>
    {
        public CategoriesPresenter(ICategoriesFrm view) : base(view)
        {
            RefreshTranslations();
        }

        public override IDgvDbAccess DbAccess => Context.Get<IFamiliesDE>();

        private const ObjectTypeId NamesObjectTypeId = ObjectTypeId.Families_Name;

        public Dictionary<long, Dictionary<long, string>> ModelIdToNamesByLanguageDictionary;

        private void RefreshTranslations()
        {
            ModelIdToNamesByLanguageDictionary = Context.GetTranslations(NamesObjectTypeId);
        }

        protected override void ExecuteDeleteDb(Families model)
        {
            ((IFamiliesDE)DbAccess).Delete(model);
            Context.DeleteTranslations(model.Id, NamesObjectTypeId);
            RefreshTranslations();
        }

        protected override void ExecuteInsertDb(Families model)
        {
            var id = ((IFamiliesDE)DbAccess).Insert(model);
            model.Id = id;
            Context.UpdateTranslations(model.Id, NamesObjectTypeId, model.LangToName);
            RefreshTranslations();
        }

        protected override void ExecuteUpdateDb(Families model)
        {
            ((IFamiliesDE)DbAccess).Update(model);
            Context.UpdateTranslations(model.Id, NamesObjectTypeId, model.LangToName);
            RefreshTranslations();
        }

        internal void EnsureLanguages(vComboBox cb)
        {
            var langs = Context.Get<ILanguagesDE>().GetAll();
            cb.DisplayMember = "Value";
            cb.ValueMember = "Id";
            cb.DataSource = langs;
        }

        public string GetNameBySelectedLanguage(long languageId, long selectedId)
        {
            string name = "";
            if (ModelIdToNamesByLanguageDictionary.TryGetValue(selectedId, out Dictionary<long, string> nameByLang))
                nameByLang.TryGetValue(languageId, out name);
            return name;
        }

        protected override object GetGridPage(int pageOffset, int maxRecords)
        {
            var categories = base.GetGridPage(pageOffset, maxRecords);

            foreach (var category in categories as List<Families>)
            {
                category.LangToName = ModelIdToNamesByLanguageDictionary.ContainsKey(category.Id) ?
                    ModelIdToNamesByLanguageDictionary[category.Id] : new Dictionary<long, string>();
            }

            return categories;
        }

    }
}
