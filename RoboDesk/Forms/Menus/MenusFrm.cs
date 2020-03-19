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

namespace RoboDesk
{
    public partial class MenusFrm : MetroFramework.Forms.MetroForm, IMenusFrm
    {
        private MenusPresenter presenter;
        public MenusFrm()
        {
            InitializeComponent();
            presenter = new MenusPresenter(this);
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

        private Dictionary<long, string> EditedLangToName = new Dictionary<long, string>();

        public void ExecuteBackClick()
        {
            FormNavigator.OpenForm<MainFrm>(this);
        }

        public void BindModelToView(Menus selectedModel)
        {
            EditedLangToName = new Dictionary<long, string>();

            foreach (long lang in cb_Language.Items.Select(x => x.Value))
            {
                EditedLangToName[lang] = presenter.GetNameBySelectedLanguage(lang);
            }

            tb_Code.Text = selectedModel.Code;
            tb_Description.Text = selectedModel.Description;
            tb_Discount.Text = selectedModel.Discount.ToString();
            tb_Price.Text = selectedModel.Price.ToString();

            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            tb_Name.Text = presenter.GetNameBySelectedLanguage(selectedLangId);
        }

        public void VerifyView()
        {
            if (tb_Code.Text == string.Empty)
                throw new Exception("Code should not be empty!");
            if (tb_Name.Text == string.Empty)
                throw new Exception("Name should not be empty!");
        }

        public Menus BindViewToModel(Menus model)
        {
            model.Code = tb_Code.Text;
                model.Description = tb_Description.Text;
            model.Discount = Decimal.Parse(tb_Discount.Text);
            model.Price = Decimal.Parse(tb_Price.Text);

            model.LangToName = model.LangToName ?? new Dictionary<long, string>();
            foreach (var lang in EditedLangToName.Keys)
                model.LangToName[lang] = EditedLangToName[lang];

            return model;
        }

        private void cb_Language_SelectedItemChanged(object sender, EventArgs e)
        {
            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            EditedLangToName.TryGetValue(selectedLangId, out string name);
            tb_Name.Text = name;
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            EditedLangToName[selectedLangId] = tb_Name.Text;
        }
    }
}
