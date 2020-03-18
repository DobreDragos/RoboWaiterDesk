using RoboDesk.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using BusinessLayer;
using System.Threading;
using DataLayerStandard.DataEntities;
using DataLayerHelper;
using RoboDesk.Forms.Login;
using DataLayerHelper.CustomExceptions;
using GlobalClassesStandard.Utils;
using RoboDesk.Interfaces;
using RoboDesk.Utils;

namespace RoboDesk
{
    public partial class LoginFrm : MetroFramework.Forms.MetroForm, ILoginFrm
    {
        private LoginPresenter presenter;
        public LoginFrm()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
            cbLanguage_SelectedIndexChanged(null, null);
        }

        public string User { get => tb_User.Text ; set => tb_User.Text = value; }
        public string Pass { get => tb_Pass.Text; set => tb_Pass.Text = value; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
#if DEBUG
                User = "Administrator";
                Pass = "admin";
#endif
                presenter.Login();
                FormNavigator.OpenForm<MainFrm>(this);
            }
            catch (PresenterException pe)
            {
                MyMessageBox.ShowDialog(this, pe.Message,"Robo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowException(this, ex);
            }
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbLanguage.BackgroundImage = cbLanguage.SelectedIndex == 0? Properties.Resources.ro : Properties.Resources.en;
            presenter.ChangeLanguage(cbLanguage.SelectedIndex);
        }
    }
}
