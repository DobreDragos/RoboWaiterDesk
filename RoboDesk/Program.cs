using GlobalClassesStandard.Utils;
using MetroFramework.Components;
using RoboDesk.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboDesk
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormNavigator.TransitionSpeed = Properties.Settings.Default.TransitionSpeed;
            FormNavigator.OpenForm<LoginFrm>(null);
            Application.Run();
            
        }
    }
}
