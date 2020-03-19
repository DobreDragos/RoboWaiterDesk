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
        public MenusPresenter(IMenusFrm view) : base(view)
        {
            ModelIdToNamesByLanguageDictionary = new Dictionary<long, Dictionary<long, string>>();
        }

        public override IDgvDbAccess DbAccess => Context.Get<IMenusDE>();

        public Dictionary<long, Dictionary<long, string>> ModelIdToNamesByLanguageDictionary;

        protected override void ExecuteDeleteDb(Menus model)
        {
            ((IMenusDE)DbAccess).Delete(model);
            Context.DeleteNames(model.Id, ObjectTypeId.Menus);
            ModelIdToNamesByLanguageDictionary = Context.GetTranslations(ObjectTypeId.Menus);
        }

        protected override void ExecuteInsertDb(Menus model)
        {
            ((IMenusDE)DbAccess).Insert(model);
            Context.UpdateNames(model.Id, ObjectTypeId.Menus, model.LangToName);
            ModelIdToNamesByLanguageDictionary = Context.GetTranslations(ObjectTypeId.Menus);
        }

        protected override void ExecuteUpdateDb(Menus model)
        {
            ((IMenusDE)DbAccess).Update(model);
            Context.UpdateNames(model.Id, ObjectTypeId.Menus, model.LangToName);
            ModelIdToNamesByLanguageDictionary = Context.GetTranslations(ObjectTypeId.Menus);
        }

        internal void EnsureLanguages(vComboBox cb)
        {
            var langs = Context.Get<ILanguagesDE>().GetAll();
            cb.DisplayMember = "Value";
            cb.ValueMember = "Id";
            cb.DataSource = langs;
        }

        internal string GetNameBySelectedLanguage(long lang)
        {
            string name = "";
            var id = SelectedModel?.Id;
            if (id.HasValue && ModelIdToNamesByLanguageDictionary.TryGetValue(id.Value, out Dictionary<long, string> nameByLang))
                nameByLang.TryGetValue(lang, out name);
            return name;
        }

        protected override object GetGridPage(int pageOffset, int maxRecords)
        {
            var products = base.GetGridPage(pageOffset, maxRecords);

            foreach (var product in products as List<Menus>)
            {
                product.LangToName = ModelIdToNamesByLanguageDictionary.ContainsKey(product.Id) ?
                    ModelIdToNamesByLanguageDictionary[product.Id] : new Dictionary<long, string>();
            }

            return products;
        }
    }
}
