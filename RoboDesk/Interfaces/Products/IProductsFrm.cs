using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIBlend.WinForms.Controls;

namespace RoboDesk.Interfaces
{
    public interface IProductsFrm : ICrudFormBase<Products>
    {
        PictureBox PicBox { get; }
    }
}
