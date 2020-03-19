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
    public class ProductsPresenter : CrudPresenterBase<IProductsFrm, Products>
    {
        Dictionary<long, Dictionary<long, string>> ProductIdToNamesByLanguageDictionary;
        public ProductsPresenter(IProductsFrm view) : base(view)
        {
            ProductIdToNamesByLanguageDictionary = Context.GetTranslations(ObjectTypeId.Products);

        }

        public string GetNameBySelectedLanguage(long languageId)
        {
            string name = "";
            var id = SelectedModel?.Id;
            if (id.HasValue && ProductIdToNamesByLanguageDictionary.TryGetValue(id.Value, out Dictionary<long, string> nameByLang))
                nameByLang.TryGetValue(languageId, out name);
            return name;
        }

        public override IDgvDbAccess DbAccess => Context.Get<IProductsDE>();

        protected override void ExecuteDeleteDb(Products model)
        {
            ((IProductsDE)DbAccess).Delete(model);
            Context.DeleteNames(model.Id, ObjectTypeId.Products);
            ProductIdToNamesByLanguageDictionary = Context.GetTranslations(ObjectTypeId.Products);
        }

        protected override void ExecuteInsertDb(Products model)
        {
            ((IProductsDE)DbAccess).Insert(model);
            Context.UpdateNames(model.Id, ObjectTypeId.Products, model.LangToName);
            ProductIdToNamesByLanguageDictionary = Context.GetTranslations(ObjectTypeId.Products);
        }

        protected override void ExecuteUpdateDb(Products model)
        {
            ((IProductsDE)DbAccess).Update(model);
            Context.UpdateNames(model.Id, ObjectTypeId.Products, model.LangToName);
            ProductIdToNamesByLanguageDictionary = Context.GetTranslations(ObjectTypeId.Products);
        }

        internal void EnsureLanguages(vComboBox cb)
        {
            var langs = Context.Get<ILanguagesDE>().GetAll();
            cb.DisplayMember = "Value";
            cb.ValueMember = "Id";
            cb.DataSource = langs;
        }

        internal List<Families> EnsureFamilies(vComboBox cb)
        {
            var families = Context.Get<IFamiliesDE>().GetAll();
            cb.DisplayMember = "Code";
            cb.ValueMember = "Id";
            cb.DataSource = families;
            return families;
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
