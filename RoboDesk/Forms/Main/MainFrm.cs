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
using RoboDesk.Utils;
using RoboDesk.Interfaces;

namespace RoboDesk
{
    public partial class MainFrm : MetroFramework.Forms.MetroForm, IMainFrm
    {
        private MainPresenter presenter;
        public MainFrm()
        {
            presenter = new MainPresenter(this);
            InitializeComponent();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            //FormNavigator.OpenForm<RoboDesk.MenusFrm>(this);
        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            //FormNavigator.OpenForm<RoboDesk.MenusFrm>(this);
        }

        private void backArrowControl1_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm<RoboDesk.LoginFrm>(this);
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm<RoboDesk.ProductsFrm>(this);
        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm<RoboDesk.MenusFrm>(this);
        }

        private void btn_Tables_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm<RoboDesk.TablesFrm>(this);
        }
    }
}
