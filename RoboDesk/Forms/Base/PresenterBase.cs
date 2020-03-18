using BusinessLayer;
using DataLayerHelper;
using DataLayerHelper.Models;
using GlobalClassesStandard.Utils;
using RoboDesk.Interfaces;
using RoboDesk.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboDesk.Forms.Base
{
    public abstract class PresenterBase<T> where T:IFormBase
    {
        protected T View { get; set; }
        protected virtual ResourceManager Res { get { return Properties.Resources.ResourceManager; } }
        /// <summary>
        /// Returns the businiess layer manager
        /// </summary>
        public static IContext Context => Globals.Context;

        public PresenterBase(T view)
        {
            this.View = view;
            SetBackColor();
            view.Load += (s, e) => { InitializeView(); };
        }

        public virtual void InitializeView()
        {
            WinFormExtensions.LocalizeLabels(View as Control, Res);
        }

        private void SetBackColor()
        {
            //try
            //{
            //    if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.BackColor))
            //    {
            //        var colors = Properties.Settings.Default.BackColor.Split(',');
            //        View.BackColor = Color.FromArgb(Convert.ToInt32(colors[0]), Convert.ToInt32(colors[1]), Convert.ToInt32(colors[2]));
            //        View.BackgroundImage = null;
            //    }
            //    if (System.IO.File.Exists(Properties.Settings.Default.BackImage))
            //        View.BackgroundImage = Image.FromFile(Properties.Settings.Default.BackImage);
            //}
            //catch (Exception e)
            //{
            //    Logger.LogHelper.Logger.Error("Could not set back color : " + e.Message);
            //}
        }
    }
}
