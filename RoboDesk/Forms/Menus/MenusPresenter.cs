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
using System.Windows.Forms;

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

        internal void EnsureExistingProducts(ListBox lb)
        {
            var prods = Context.Get<IProductsDE>().GetAll();
            SetProductsListbox(lb, prods);
        }

        public void SetProductsListbox(ListBox lb, List<Products> products)
        {
            var clonedListbox = new List<Products>();
            clonedListbox.AddRange(products);

            lb.DataSource = null;
            lb.DisplayMember = "Code";
            lb.ValueMember = "Id";
            lb.DataSource = clonedListbox;
        }

        public override IDgvDbAccess DbAccess => Context.Get<IMenusDE>();

        public Dictionary<long, Dictionary<long, string>> ModelIdToNamesByLanguageDictionary;
        public Dictionary<long, Dictionary<long, string>> ModelIdToDescriptionByLanguageDictionary;

        protected override void ExecuteDeleteDb(Menus model)
        {
            ((IMenusDE)DbAccess).Delete(model);
            Context.DeleteTranslations(model.Id, ObjectTypeName);
            Context.DeleteTranslations(model.Id, ObjectTypeDescription);
            var menuProductsDE = Context.Get<IMenuProductsDE>();
            menuProductsDE.DeleteAll("IdMenu", model.Id);
            RefreshTranslations();
        }

        protected override void ExecuteInsertDb(Menus model)
        {
            var id = ((IMenusDE)DbAccess).Insert(model);
            model.Id = id;
            UpdateChildren(model);
            
        }

        protected override void ExecuteUpdateDb(Menus model)
        {
            ((IMenusDE)DbAccess).Update(model);

            UpdateChildren(model);
        }

        private void UpdateChildren(Menus model)
        {
            var menuProductsDE = Context.Get<IMenuProductsDE>();
            menuProductsDE.DeleteAll("IdMenu", model.Id);
            foreach (var prod in model.Products)
                menuProductsDE.Insert(new MenuProducts() { IdMenu = model.Id, IdProduct = prod.Id });

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
            var menus = base.GetGridPage(pageOffset, maxRecords);

            foreach (var menu in menus as List<Menus>)
            {
                menu.LangToName = ModelIdToNamesByLanguageDictionary.ContainsKey(menu.Id) ?
                    ModelIdToNamesByLanguageDictionary[menu.Id] : new Dictionary<long, string>();
                menu.LangToName = ModelIdToDescriptionByLanguageDictionary.ContainsKey(menu.Id) ?
                    ModelIdToNamesByLanguageDictionary[menu.Id] : new Dictionary<long, string>();

                var menuToProds = Context.Get<IMenuProductsDE>().GetAllFromDb(new SqlFilter("IdMenu", menu.Id));
                menu.Products = new List<Products>();
                var prodDE = Context.Get<IProductsDE>();
                foreach (var menuToProd in menuToProds)
                {
                    var product = prodDE.GetById(menuToProd.IdProduct);
                    if (product != null)
                        menu.Products.Add(product);
                }


            }

            return menus;
        }
    }
}
