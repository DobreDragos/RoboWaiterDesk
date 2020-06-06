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
using RoboDesk.Interfaces.Categories;

namespace RoboDesk
{
    public partial class CategoriesFrm : MetroFramework.Forms.MetroForm, ICategoriesFrm
    {
        private CategoriesPresenter presenter;
        public CategoriesFrm()
        {
            InitializeComponent();
            presenter = new CategoriesPresenter(this);

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

        private void cb_Language_SelectedItemChanged(object sender, EventArgs e)
        {
            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            EditedLangToName.TryGetValue(selectedLangId, out string name);
            tb_CategoryName.Text = name;
        }

        private void tb_CategoryName_TextChanged(object sender, EventArgs e)
        {
            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            EditedLangToName[selectedLangId] = tb_CategoryName.Text;
        }

        public void ExecuteBackClick()
        {
            FormNavigator.OpenForm<MainFrm>(this);
        }

        public void BindModelToView(Families selectedModel)
        {
            tb_CategoryCode.Text = selectedModel.Code;

            EditedLangToName = new Dictionary<long, string>();

            foreach (long lang in cb_Language.Items.Select(x => x.Value))
            {
                EditedLangToName[lang] = presenter.GetNameBySelectedLanguage(lang, selectedModel.Id);
            }
            var selectedLangId = (cb_Language.SelectedValue as long?).GetValueOrDefault();
            tb_CategoryName.Text = EditedLangToName[selectedLangId];
        }

        public void VerifyView()
        {
            if (tb_CategoryCode.Text == string.Empty)
                throw new Exception("Code should not be empty!");

            if (tb_CategoryName.Text == string.Empty)
                throw new Exception("Name should not be empty!");
        }

        public Families BindViewToModel(Families model)
        {
            model.Code = tb_CategoryCode.Text;
            model.LangToName = model.LangToName ?? new Dictionary<long, string>();
            foreach (var lang in EditedLangToName.Keys)
                model.LangToName[lang] = EditedLangToName[lang];

            return model;
        }

    }
}
