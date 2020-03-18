using DataLayerHelper.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboDesk.Interfaces
{
    /// <summary>
    /// Interface containing base fields and methods that all application's forms must implement
    /// </summary>
    public interface IFormBase :IWin32Window
    {
        string Name { get; set; }

        void Close();

        bool IsDisposed { get; }

        void Show();

        void Hide();

        Color BackColor
        {
            get; set;
        }
        
        double Opacity { get; set; }

        bool Enabled { get; set; }

        //
        // Summary:
        //     Occurs before a form is displayed for the first time.
        event EventHandler Load;

        event FormClosedEventHandler FormClosed;

        int Width { get; set; }

        int Height { get; set; }

        Size MinimumSize { get; set; }

    }
}
