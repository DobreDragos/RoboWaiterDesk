﻿using System;
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
        Dictionary<long, Dictionary<long, string>> ModelIdToNamesByLanguageDictionary;
        Dictionary<long, Dictionary<long, string>> ModelIdToDescriptionByLanguageDictionary;
        Dictionary<long, Dictionary<long, string>> ModelIdToAlergensByLanguageDictionary;
        public ProductsPresenter(IProductsFrm view) : base(view)
        {
            RefreshTranslations();
        }

        private void RefreshTranslations()
        {
            ModelIdToNamesByLanguageDictionary = Context.GetTranslations(NamesObjectTypeId);
            ModelIdToDescriptionByLanguageDictionary = Context.GetTranslations(DescriptionObjectTypeId);
            ModelIdToAlergensByLanguageDictionary = Context.GetTranslations(AlergensObjectTypeId);
        }

        public string GetNameBySelectedLanguage(long languageId, long selectedId)
        {
            string name = "";
            if (ModelIdToNamesByLanguageDictionary.TryGetValue(selectedId, out Dictionary<long, string> nameByLang))
                nameByLang.TryGetValue(languageId, out name);
            return name;
        }
        public string GetDescriptionBySelectedLanguage(long languageId, long selectedId)
        {
            string name = "";
            if (ModelIdToDescriptionByLanguageDictionary.TryGetValue(selectedId, out Dictionary<long, string> nameByLang))
                nameByLang.TryGetValue(languageId, out name);
            return name;
        }
        public string GetAlergensBySelectedLanguage(long languageId, long selectedId)
        {
            string name = "";
            if (ModelIdToAlergensByLanguageDictionary.TryGetValue(selectedId, out Dictionary<long, string> nameByLang))
                nameByLang.TryGetValue(languageId, out name);
            return name;
        }

        public override IDgvDbAccess DbAccess => Context.Get<IProductsDE>();

        private const ObjectTypeId NamesObjectTypeId = ObjectTypeId.Products_Name;

        private const ObjectTypeId DescriptionObjectTypeId = ObjectTypeId.Products_Description;

        private const ObjectTypeId AlergensObjectTypeId = ObjectTypeId.Products_Alergens;

        protected override void ExecuteDeleteDb(Products model)
        {
            ((IProductsDE)DbAccess).Delete(model);
            Context.DeleteTranslations(model.Id, NamesObjectTypeId);
            Context.DeleteTranslations(model.Id, DescriptionObjectTypeId);
            Context.DeleteTranslations(model.Id, AlergensObjectTypeId);
            RefreshTranslations();
        }

        protected override void ExecuteInsertDb(Products model)
        {
            var id = ((IProductsDE)DbAccess).Insert(model);
            Context.UpdateTranslations(model.Id, NamesObjectTypeId, model.LangToName);
            Context.UpdateTranslations(model.Id, DescriptionObjectTypeId, model.LangToDescription);
            Context.UpdateTranslations(model.Id, AlergensObjectTypeId, model.LangToAlergens);
            RefreshTranslations();
        }

        protected override void ExecuteUpdateDb(Products model)
        {
            ((IProductsDE)DbAccess).Update(model);
            Context.UpdateTranslations(model.Id, NamesObjectTypeId, model.LangToName);
            Context.UpdateTranslations(model.Id, DescriptionObjectTypeId, model.LangToDescription);
            Context.UpdateTranslations(model.Id, AlergensObjectTypeId, model.LangToAlergens);
            RefreshTranslations();
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
                product.LangToName = ModelIdToNamesByLanguageDictionary.ContainsKey(product.Id)?
                    ModelIdToNamesByLanguageDictionary[product.Id] : new Dictionary<long, string>();

                product.LangToDescription = ModelIdToDescriptionByLanguageDictionary.ContainsKey(product.Id) ?
                    ModelIdToDescriptionByLanguageDictionary[product.Id] : new Dictionary<long, string>();

                product.LangToAlergens= ModelIdToAlergensByLanguageDictionary.ContainsKey(product.Id) ?
                    ModelIdToAlergensByLanguageDictionary[product.Id] : new Dictionary<long, string>();
            }

            return products;
        }
    }
}
