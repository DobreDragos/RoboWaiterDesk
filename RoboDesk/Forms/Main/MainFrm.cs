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

            DrawReflections();
        }

        private void DrawReflections()
        {
            Timer t = new Timer{Interval = 1};
            t.Tick += (s, e) =>
            {

                this.vImageReflectionControl.Location = new Point(this.vBubbleBar1.Location.X, this.vBubbleBar1.Bounds.Bottom);
                this.vImageReflectionControl.Invalidate();

                if (!this.vBubbleBar1.IsAnimating)
                {
                    t.Stop();
                }

            };
            this.vBubbleBar1.AnimationStarted += (s, e) =>
            {
                t.Start();
            };
            this.vBubbleBar1.AnimationFinished += (s, e) =>
            {
                this.vImageReflectionControl.Location = new Point(this.vBubbleBar1.Location.X, this.vBubbleBar1.Bounds.Bottom);
                this.vImageReflectionControl.Invalidate();
                t.Stop();
            };
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm<RoboDesk.MenusFrm>(this);
        }

        private void backArrowControl1_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm<RoboDesk.LoginFrm>(this);
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm<RoboDesk.ProductsFrm>(this);
        }
    }
}
