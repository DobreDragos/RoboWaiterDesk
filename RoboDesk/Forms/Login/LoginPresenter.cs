using DataLayerStandard.DataEntities;
using DataLayerHelper;
using DataLayerHelper.CustomExceptions;
using DataLayerHelper.Enums;
using GlobalClassesStandard.Utils;
using RoboDesk.Forms.Base;
using RoboDesk.Interfaces;
using RoboDesk.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboDesk.Forms.Login
{
    public class LoginPresenter : PresenterBase<ILoginFrm>
    {
        public LoginPresenter(ILoginFrm view) : base(view)
        {
        }

        internal void Login()
        {
            Globals.CurrentUser = Context.Get<IUsersDE>().Login(View.User, View.Pass);
            if (Globals.CurrentUser == null)
                throw new PresenterException(ExCode.LoginFailed, Properties.Resources.ERR_LOGIN_FAILED);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedIndex">0 for RO, 1 for EN</param>
        internal void ChangeLanguage(int selectedIndex)
        {
            string culture = selectedIndex == 0 ? "ro" : "en";
            var cultureUIInfo = CultureInfo.GetCultureInfo(culture);
            var cultureInfo = CultureInfo.GetCultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureUIInfo;
            //System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            WinFormExtensions.LocalizeLabels(View as Control, Res);
        }
    }
}
