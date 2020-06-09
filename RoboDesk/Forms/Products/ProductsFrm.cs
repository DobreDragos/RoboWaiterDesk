using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalClassesStandard.Utils;
using DataLayerStandard.DataEntities;
using RoboDesk.Properties;
using System.Data.SQLite;
using GlobalClassesStandard.Models;
using DataLayerHelper.Enums;
using RoboDesk.Interfaces;
using RoboDesk.Utils;
using In.Sontx.SimpleDataGridViewPaging;
using RoboDesk.CustomControls;
using VIBlend.WinForms.Controls;
using System.Text.RegularExpressions;

namespace RoboDesk
{
    public partial class ProductsFrm : MetroFramework.Forms.MetroForm, IProductsFrm
    {
        readonly ProductsPresenter presenter;
        public ProductsFrm()
        {
            InitializeComponent();
            presenter = new ProductsPresenter(this);

            presenter.EnsureFamilies(cb_Family);
            presenter.EnsureDiscountTypes(cb_DiscountIntervalType);
            presenter.EnsureLanguages(cb_Language);
        }

        
        public DataGridView Dgv => this.dgv.DataGridView;

        public Button Btn_Save => this.btn_Save;

        public Button Btn_Edit => this.btn_Edit;

        public Button Btn_Delete => this.btn_Delete;

        public Button Btn_Add => this.btn_Add;

        public TextBox Tb_Search => this.tb_Search.TextBox;

        public BackArrowControl Btn_Back => this.backArrowControl1;

        public Panel Details_Panel => this.detailsPanel;

        public DataGridViewPaging DgvPaging => this.dgv;

        public Button Btn_Cancel => this.btn_Cancel;

        private Dictionary<long, string> EditedLangToAlergens = new Dictionary<long, string>();
        private Dictionary<long, string> EditedLangToName = new Dictionary<long, string>();

        private Dictionary<long, string> EditedLangToDescription = new Dictionary<long, string>();

        public void ExecuteBackClick()
        {
            FormNavigator.OpenForm<MainFrm>(this);
        }

        public void BindModelToView(Products selectedModel)
        {
            EditedLangToName = new Dictionary<long, string>();
            EditedLangToDescription = new Dictionary<long, string>();
            EditedLangToAlergens = new Dictionary<long, string>();

            foreach (long lang in cb_Language.Items.Select(x => x.Value))
            {
                EditedLangToName[lang] = presenter.GetNameBySelectedLanguage(lang, selectedModel.Id);
                EditedLangToDescription[lang] = presenter.GetDescriptionBySelectedLanguage(lang, selectedModel.Id);
                EditedLangToAlergens[lang] = presenter.GetAlergensBySelectedLanguage(lang, selectedModel.Id);
            }

            tb_Code.Text = selectedModel.Code;
            tb_Discount.Text = selectedModel.Discount.ToString();
            tb_Price.Text = selectedModel.Price.ToString();
            if (selectedModel.Id == 0) // if new then select first always
                cb_Family.SelectedIndex = 0;
            else
                cb_Family.SelectedValue = selectedModel.IdFamily; 
            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();

            tb_Name.Text = EditedLangToName[selectedLangId];
            tb_Description.Text = EditedLangToDescription[selectedLangId];
            tb_Alergens.Text = EditedLangToAlergens[selectedLangId];
            cb_Enabled.Checked = selectedModel.Enabled;
            tb_DiscountInterval.Text = selectedModel.DiscountStart == null ? "" : $"{selectedModel.DiscountStart.Value.ToString("HH:mm")}-{selectedModel.DiscountEnd.Value.ToString("HH:mm")}"; ;
            cb_DiscountIntervalType.SelectedValue = selectedModel.DiscountType;
        }

        public void VerifyView()
        {
            if (tb_Code.Text == string.Empty)
                throw new Exception("Code should not be empty!");
            if (tb_Name.Text == string.Empty)
                throw new Exception("Name should not be empty!");
            if (cb_Family.SelectedValue == null)
                throw new Exception("Family should not be empty!");
            if (tb_DiscountInterval.Text != "" && tb_Discount.Text != "" && !Regex.IsMatch(tb_DiscountInterval.Text.Replace(" ", ""), @"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]-(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$")) {
                throw new Exception("Please set a correct Discount Interval! It should be empty or like '08:00 - 13:30'");
            }
        }

        public Products BindViewToModel(Products _selectedModel)
        {
            _selectedModel.Code = tb_Code.Text;
            _selectedModel.Discount = Decimal.Parse(tb_Discount.Text);
            _selectedModel.Price = Decimal.Parse(tb_Price.Text);
            _selectedModel.IdFamily = (long)cb_Family.SelectedValue;
            _selectedModel.DiscountType = (int)cb_DiscountIntervalType.SelectedValue;

            var discountSelection = tb_DiscountInterval.Text.Replace(" ", "").Split('-');
            if (discountSelection.Count() == 2)
            {
                _selectedModel.DiscountStart = DateTime.Parse(discountSelection[0]);
                _selectedModel.DiscountEnd = DateTime.Parse(discountSelection[1]);
            }
            else
            {
                _selectedModel.DiscountStart = null;
                _selectedModel.DiscountEnd = null;
            }

            _selectedModel.Enabled = cb_Enabled.Checked;

            _selectedModel.LangToName = _selectedModel.LangToName ?? new Dictionary<long, string>();
            foreach (var lang in EditedLangToName.Keys)
                _selectedModel.LangToName[lang] = EditedLangToName[lang];

            _selectedModel.LangToDescription = _selectedModel.LangToDescription ?? new Dictionary<long, string>();
            foreach (var lang in EditedLangToDescription.Keys)
                _selectedModel.LangToDescription[lang] = EditedLangToDescription[lang];

            _selectedModel.LangToAlergens = _selectedModel.LangToAlergens ?? new Dictionary<long, string>();
            foreach (var lang in EditedLangToAlergens.Keys)
                _selectedModel.LangToAlergens[lang] = EditedLangToAlergens[lang];

            return _selectedModel;
        }

        private void cb_Language_SelectedItemChanged(object sender, EventArgs e)
        {
            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            EditedLangToName.TryGetValue(selectedLangId, out string name);
            tb_Name.Text = name;

            EditedLangToDescription.TryGetValue(selectedLangId, out string description);
            tb_Description.Text = description;

            EditedLangToAlergens.TryGetValue(selectedLangId, out string alergens);
            tb_Alergens.Text = alergens;
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            EditedLangToName[selectedLangId] = tb_Name.Text;
        }

        private void tb_Alergens_TextChanged(object sender, EventArgs e)
        {
            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            EditedLangToAlergens[selectedLangId] = tb_Alergens.Text;
        }

        private void tb_Description_TextChanged(object sender, EventArgs e)
        {
            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            EditedLangToDescription[selectedLangId] = tb_Description.Text;
        }
    }
}
