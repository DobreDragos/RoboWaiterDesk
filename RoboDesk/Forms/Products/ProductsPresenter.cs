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
using System.IO;
using RoboDesk.Properties;
using System.Drawing;
using System.Threading;
using Logger;

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
            Families = Context.Get<IFamiliesDE>().GetAll();
        }

        private void RefreshTranslations()
        {
            ModelIdToNamesByLanguageDictionary = Context.GetTranslations(NamesObjectTypeId);
            ModelIdToDescriptionByLanguageDictionary = Context.GetTranslations(DescriptionObjectTypeId);
            ModelIdToAlergensByLanguageDictionary = Context.GetTranslations(AlergensObjectTypeId);
        }

        internal void EnsureDiscountTypes(vComboBox cb)
        {
            List<Tuple<int, string>> myList = new List<Tuple<int, string>>();
            foreach (var en in Enum.GetValues(typeof(DiscountIntervalType)).Cast<DiscountIntervalType>())
            {
                myList.Add(new Tuple<int, string>((int)en, en.ToString()));
            }

            cb.DisplayMember = "Item2";
            cb.ValueMember = "Item1";
            cb.DataSource = myList;
        }

        protected override void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.CancelTempPictures();
            base.Btn_Cancel_Click(sender, e);
        }

        protected override void Btn_Back_Click(object sender, EventArgs e)
        {
            this.CancelTempPictures();
            base.Btn_Back_Click(sender, e);
        }
        

        protected override void Btn_Save_Click(object sender, EventArgs e)
        {
            this.SaveTempPictures();
            base.Btn_Save_Click(sender, e);
        }

        protected override void DeleteModel()
        {
            this.DeleteProductPicture();
            base.DeleteModel();
        }

        public void SetProductImage(string fileLocation = "")
        {
            try
            {
                this.View.PicBox.BackgroundImage?.Dispose();
                if (string.IsNullOrEmpty(fileLocation))
                    this.View.PicBox.BackgroundImage = new Bitmap(Resources.noimage);
                else
                    this.View.PicBox.BackgroundImage = GetCopyImage(fileLocation);
            }
            catch(Exception ex)
            {
                LogHelper.Logger.Error(ex);
            }
        }

        private Image GetCopyImage(string path)
        {
            using (Image image = Image.FromFile(path))
            {
                Bitmap bitmap = new Bitmap(image);
                return bitmap;
            }
        }

        private void SaveTempPictures()
        {
            try
            {
                string fileLocation = Path.Combine(Settings.Default.ProductPictureLocation, string.Format("{0}.jpg", this.SelectedModel.Code));
                string fileLocationAddTemp = Path.Combine(Settings.Default.ProductPictureLocation, string.Format("{0}_addtemp.jpg", this.SelectedModel.Code));
                string fileLocationDeleteTemp = Path.Combine(Settings.Default.ProductPictureLocation, string.Format("{0}_deletetemp.jpg", this.SelectedModel.Code));
                if (File.Exists(fileLocationAddTemp))
                {
                    File.Copy(fileLocationAddTemp, fileLocation, true);
                    SetProductImage(fileLocation);
                    File.Delete(fileLocationAddTemp);
                }

                if (File.Exists(fileLocationDeleteTemp))
                {
                    File.Delete(fileLocationDeleteTemp);
                }
            }
            catch(Exception ex)
            {
                LogHelper.Logger.Error(ex);
            }
        }

        private void CancelTempPictures()
        {
            try
            {
                string fileLocation = Path.Combine(Settings.Default.ProductPictureLocation, string.Format("{0}.jpg", this.SelectedModel.Code));
                string fileLocationAddTemp = Path.Combine(Settings.Default.ProductPictureLocation, string.Format("{0}_addtemp.jpg", this.SelectedModel.Code));
                string fileLocationDeleteTemp = Path.Combine(Settings.Default.ProductPictureLocation, string.Format("{0}_deletetemp.jpg", this.SelectedModel.Code));

                SetProductImage();

                if (File.Exists(fileLocationAddTemp))
                {
                    File.Delete(fileLocationAddTemp);
                }

                if (File.Exists(fileLocationDeleteTemp))
                {
                    File.Copy(fileLocationDeleteTemp, fileLocation, true);
                    File.Delete(fileLocationDeleteTemp);
                }

                if (File.Exists(fileLocation))
                {
                    SetProductImage(fileLocation);
                }
            }
            catch(Exception ex)
            {
                LogHelper.Logger.Error(ex);
            }
        }

        private void DeleteProductPicture()
        {
            try
            {
                string fileLocation = Path.Combine(Settings.Default.ProductPictureLocation, string.Format("{0}.jpg", this.SelectedModel.Code));
                if (File.Exists(fileLocation))
                {
                    SetProductImage();
                    File.Delete(fileLocation);
                }
            }
            catch(Exception ex)
            {
                LogHelper.Logger.Error(ex);
            }
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

        public List<Families> Families { get; }

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
            model.Id = id;
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
            var prodList = ((IProductsDE)DbAccess).GetAll()
                .OrderBy(x => x.IdFamily).ThenBy(x => x.Code)
                .Skip(pageOffset).Take(maxRecords).ToList();

            foreach (var product in prodList)
            {
                product.LangToName = ModelIdToNamesByLanguageDictionary.ContainsKey(product.Id)?
                    ModelIdToNamesByLanguageDictionary[product.Id] : new Dictionary<long, string>();

                product.LangToDescription = ModelIdToDescriptionByLanguageDictionary.ContainsKey(product.Id) ?
                    ModelIdToDescriptionByLanguageDictionary[product.Id] : new Dictionary<long, string>();

                product.LangToAlergens= ModelIdToAlergensByLanguageDictionary.ContainsKey(product.Id) ?
                    ModelIdToAlergensByLanguageDictionary[product.Id] : new Dictionary<long, string>();

                product.FamilyCode = Families.FirstOrDefault(x => x.Id == product.IdFamily).Code;
            }

            return prodList;
        }
    }
}
