
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIBlend.WinForms.Controls;

namespace RoboDesk.Util
{
    public static class WinFormExtensions
    {

        public static void LocalizeLabels(Control ctrl, ResourceManager res)
        {
            try
            {
                IEnumerable<Control> ctrlList = GetContainedControls(ctrl);
                ctrl.Text = res.GetString(ctrl.Name) ?? "???";
                foreach (Control c in ctrlList)
                {
                    var name = c.Name.ToUpper();

                    if (c is Label ||
                        c is CheckBox ||
                        c is RadioButton ||
                        c is Button ||
                        c is GroupBox
                        )
                    {
                        if (string.IsNullOrEmpty(name))
                            continue;
                        var val = res.GetString(name);
                        c.Text = val ?? "???";
                    }
                    else if (c is vTextBox)
                    {
                        var val = res.GetString(name);
                        ((vTextBox)c).DefaultText = val ?? "";
                    }
                    else if (c is vComboBox)
                    {
                        var val = res.GetString(name);
                        ((vComboBox)c).DefaultText = val ?? res.GetString("CB_DEFAULT_SELECT");
                    }
                }

            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Gets a list that contains all the child controls of the control
        /// </summary>
        /// <param name="ctrl">The control which children are required</param>
        /// <param name="includeParent">If true, the list will also include the parent itself</param>
        /// <param name="resettingControls"></param>
        /// <returns></returns>
        public static IEnumerable<Control> GetContainedControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetContainedControls(ctrl))
                                      .Concat(controls);
        }
        /// <summary>
        /// Localizes a data grid view
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="res"></param>
        public static void LocalizeGrid(DataGridView dgv, ResourceManager res)
        {
            try
            {
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    string s = res.GetString("DGV_" + dgv.Columns[i].DataPropertyName.ToUpper());

                    if (string.IsNullOrEmpty(s))
                    {
                        dgv.Columns[i].Visible = false;
                    }
                    else
                    {
                        dgv.Columns[i].HeaderText = s;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
