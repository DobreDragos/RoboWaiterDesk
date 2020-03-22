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
    public partial class TablesFrm : MetroFramework.Forms.MetroForm, ITablesFrm
    {
        private TablesPresenter presenter;
        public TablesFrm()
        {
            InitializeComponent();
            presenter = new TablesPresenter(this);
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


        public void ExecuteBackClick()
        {
            FormNavigator.OpenForm<MainFrm>(this);
        }

        public void BindModelToView(Tables selectedModel)
        {
            tb_Code.Text = selectedModel.Token;
        }

        public void VerifyView()
        {
            if (tb_Code.Text == string.Empty)
                throw new Exception("Code should not be empty!");
            }

        public Tables BindViewToModel(Tables model)
        {
            model.Token = tb_Code.Text;

            return model;
        }

    }
}
