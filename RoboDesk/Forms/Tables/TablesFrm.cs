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
using QRCodeLibrary;
using System.Diagnostics;
using System.IO;
using RoboDesk.Util;

namespace RoboDesk
{
    public partial class TablesFrm : MetroFramework.Forms.MetroForm, ITablesFrm
    {
        private TablesPresenter presenter;
        public TablesFrm()
        {
            InitializeComponent();
            presenter = new TablesPresenter(this);

            this.Load += (s, e) =>
            {
                this.lbl_IPValue.Text = QRUtils.GetIPAddress();
                this.lbl_QRLocation.Text = Settings.Default.QrCodeLocation;
            };
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

        private void btn_GenerateQR_Click(object sender, EventArgs e)
        {
            this.SafeExecuteAction(() =>
            {
                if (!Directory.Exists(Settings.Default.QrCodeLocation))
                {
                    MyMessageBox.ShowDialog(this, $"QR location does not exist: {Settings.Default.QrCodeLocation}. Check config.", "Robo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(Settings.Default.QrCodeLocation);

                    foreach (FileInfo file in directoryInfo.GetFiles("*.jpg"))
                    {
                        file.Delete();
                    }
                    List<Tables> tables = presenter.GetAll();
                    List<string> tablesCodes = new List<string>();
                    foreach (Tables table in tables)
                        tablesCodes.Add(table.Token);
                    string resultGenerateQR = QRCodeManager.GenerateQR(Settings.Default.QrCodeLocation, this.lbl_IPValue.Text, Settings.Default.Protocol, tablesCodes);
                    MyMessageBox.ShowDialog(this, resultGenerateQR, "Robo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(Settings.Default.QrCodeLocation);
                }
            });
        }
    }
}
