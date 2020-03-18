using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboDesk.CustomControls
{
    public partial class BackArrowControl : UserControl
    {
        private Point initialValues;
        private const double clickResize = 0.95;
        private const double mouseEnterResize = 1.05;

        public BackArrowControl()
        {
            InitializeComponent();
            this.Load += (s, e) => { initialValues = new Point(this.Height, this.Width);
            };
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Height = (int)(initialValues.X * clickResize);
            this.Width= (int)(initialValues.Y * clickResize);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            SetInitialValues();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            SetInitialValues();
        }

        private void SetInitialValues()
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            this.Height = (initialValues.X);
            this.Width = (initialValues.Y);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Height = (int)(initialValues.X * mouseEnterResize);
            this.Width = (int)(initialValues.Y * mouseEnterResize);
        }

        public new event EventHandler Click
        {
            add
            {
                pictureBox1.Click += value;
            }
            remove
            {
                pictureBox1.Click -= value;
            }
        }
    }
}
