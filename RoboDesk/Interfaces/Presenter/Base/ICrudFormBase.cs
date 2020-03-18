using DataLayerHelper.Enums;
using In.Sontx.SimpleDataGridViewPaging;
using RoboDesk.CustomControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayerHelper.Models;

namespace RoboDesk.Interfaces
{
    /// <summary>
    /// Interface containing base fields and methods that all application's forms must implement
    /// </summary>
    public interface ICrudFormBase<TableModel> : IFormBase where TableModel : class, IModelBase, new()
    {
        DataGridViewPaging DgvPaging { get; }
        Button Btn_Save { get; }
        Button Btn_Edit { get; }
        Button Btn_Delete { get; }
        Button Btn_Add { get; }
        Button Btn_Cancel { get; }
        TextBox Tb_Search { get; }
        BackArrowControl Btn_Back { get; }
        Panel Details_Panel { get; }

        void ExecuteBackClick();
        void VerifyView();
        void BindModelToView(TableModel selectedModel);
        TableModel BindViewToModel(TableModel oldModel);
    }
}
