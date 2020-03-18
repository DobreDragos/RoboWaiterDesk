using DataLayerStandard.DataEntities;
using DataLayerHelper;
using DataLayerHelper.CustomExceptions;
using DataLayerHelper.Enums;
using GlobalClassesStandard.Utils;
using RoboDesk.Forms.Base;
using RoboDesk.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboDesk
{
    public class MainPresenter : PresenterBase<IMainFrm>
    {
        public MainPresenter(IMainFrm view) : base(view)
        {
        }
    }
}
