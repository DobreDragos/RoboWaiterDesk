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

namespace RoboDesk
{
    public partial class ProductsFrm : MetroFramework.Forms.MetroForm, IProductsFrm
    {
        readonly ProductsPresenter presenter;
        public ProductsFrm()
        {
            EditedLangToName = new Dictionary<long, string>();
            InitializeComponent();
            presenter = new ProductsPresenter(this);

            presenter.EnsureFamilies(cb_Family);
            presenter.EnsureLanguages(cb_Language);
        }

        private Dictionary<long, string> EditedLangToName;
        
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


        public void ExecuteBackClick()
        {
            FormNavigator.OpenForm<MainFrm>(this);
        }

        public void BindModelToView(Products selectedModel)
        {
            EditedLangToName = new Dictionary<long, string>();
            tb_Code.Text = selectedModel.Code;
            tb_Description.Text = selectedModel.Description;
            tb_Discount.Text = selectedModel.Discount.ToString();
            tb_Price.Text = selectedModel.Price.ToString();
            cb_Family.SelectedValue = selectedModel.IdFamily;

            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            tb_Name.Text = presenter.GetNameBySelectedLanguage(selectedLangId);
        }

        public void VerifyView()
        {
            if (tb_Code.Text == string.Empty)
                throw new Exception("Code should not be empty!");
            if (tb_Name.Text == string.Empty)
                throw new Exception("Name should not be empty!");
            if (cb_Family.SelectedValue == null)
                throw new Exception("Family should not be empty!");
        }

        public Products BindViewToModel(Products _selectedModel)
        {
            _selectedModel.Code = tb_Code.Text;
            _selectedModel.Description = tb_Description.Text;
            _selectedModel.Discount = Decimal.Parse(tb_Discount.Text);
            _selectedModel.Price = Decimal.Parse(tb_Price.Text);
            _selectedModel.IdFamily = (long)cb_Family.SelectedValue;

            foreach (var lang in EditedLangToName.Keys)
            {
                if (_selectedModel.LangToName.ContainsKey(lang))
                {
                    _selectedModel.LangToName[lang] = EditedLangToName[lang];
                }
                else
                {
                    _selectedModel.LangToName.Add(lang, EditedLangToName[lang]);
                }
            }

            return _selectedModel;
        }

        private void cb_Language_SelectedItemChanged(object sender, EventArgs e)
        {
            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            tb_Name.Text = EditedLangToName.ContainsKey(selectedLangId)?
                EditedLangToName[selectedLangId]:
                presenter.GetNameBySelectedLanguage(selectedLangId);
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            if (EditedLangToName.ContainsKey(selectedLangId))
                EditedLangToName[selectedLangId] = tb_Name.Text;
            else
                EditedLangToName.Add(selectedLangId,tb_Name.Text);
        }
    }
}
