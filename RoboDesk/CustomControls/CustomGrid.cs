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
    public partial class CustomGrid : UserControl
    {
        public CustomGrid()
        {
            InitializeComponent();
        }
        [Description("DataGrid")]
        public DataGridView DataGrid { get => dgv; }

        public object DataSource { get => dgv.DataSource; set => dgv.DataSource = value; }
    }
}
