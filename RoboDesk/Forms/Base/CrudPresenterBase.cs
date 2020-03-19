using BusinessLayer;
using DataLayer.DataLogic;
using DataLayerHelper;
using DataLayerHelper.Classes;
using DataLayerHelper.Enums;
using DataLayerHelper.Models;
using GlobalClassesStandard.Models;
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
    public abstract class CrudPresenterBase<CrudView, TableModel> : PresenterBase<CrudView> where CrudView : ICrudFormBase<TableModel>
                                                        where TableModel : class, IModelBase,  new()
    {
        private FormStatus frmStatus;
        protected TableModel SelectedModel { get; private set; }
        public FormStatus FrmStatus { get => frmStatus; set => SetFormStatus(value); }
        public abstract IDgvDbAccess DbAccess { get;}

        protected abstract void ExecuteDeleteDb(TableModel model);
        protected abstract void ExecuteInsertDb(TableModel model);
        protected abstract void ExecuteUpdateDb(TableModel model);
        

        public CrudPresenterBase(CrudView view) : base(view)
        {
            view.Load += (s, e) =>
            {
                SafeExecuteAction(() => {
                    view.DgvPaging.DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    view.DgvPaging.DataGridView.AllowUserToAddRows = false;
                    view.DgvPaging.DataGridView.MultiSelect = false;
                    view.DgvPaging.DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    View.DgvPaging.Initialize(GetDataGridCount());
                    WinFormExtensions.LocalizeGrid(View.DgvPaging.DataGridView, base.Res);
                    SetFormStatus(FormStatus.Normal);
                });
            };
            view.DgvPaging.RequestQueryData += (s, e) =>
            {
                RefreshDatagrid(e.PageOffset, e.MaxRecords);
            };
            view.DgvPaging.DataGridView.SelectionChanged += DataGridView_SelectionChanged;
            view.Btn_Add.Click += Btn_Add_Click;
            view.Btn_Edit.Click += Btn_Edit_Click;
            view.Btn_Save.Click += Btn_Save_Click;
            view.Btn_Delete.Click += Btn_Delete_Click;
            view.Btn_Back.Click += Btn_Back_Click;
            view.Btn_Cancel.Click += Btn_Cancel_Click;
        }

        protected virtual int GetDataGridCount()
        {
            return DbAccess.GetCount(GetSearchCols().ToList(), View.Tb_Search.Text);
        }

        protected virtual void Btn_Cancel_Click(object sender, EventArgs e)
        {
            SetFormStatus(FormStatus.Normal);
            DataGridView_SelectionChanged(null, null);
        }

        protected virtual void Btn_Back_Click(object sender, EventArgs e)
        {
            View.ExecuteBackClick();
        }

        protected virtual void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (View.DgvPaging.DataGridView.SelectedRows.Count == 1)
                SelectedModel = View.DgvPaging.DataGridView.SelectedRows[0].DataBoundItem as TableModel;
            else
                SelectedModel = new TableModel();

            View.BindModelToView(SelectedModel);
        }

        protected virtual void Btn_Delete_Click(object sender, EventArgs e)
        {
            SafeExecuteAction(() => { 
                if (SelectedModel != null &&
                    MyMessageBox.ShowDialog(View, Properties.Resources.WAR_DELETE, Globals.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) 
                    == DialogResult.Yes)
                {
                    ExecuteDeleteDb(SelectedModel);
                    var crtPage = View.DgvPaging.CurrentPage;
                    RefreshDatagrid((View.DgvPaging.CurrentPage-1) * View.DgvPaging.MaxRecords , View.DgvPaging.MaxRecords);
                }
            });
        }

        protected virtual void Btn_Save_Click(object sender, EventArgs e)
        {
            SafeExecuteAction(() =>
            {
                View.VerifyView();
                View.BindViewToModel(SelectedModel);
                if (FrmStatus == FormStatus.Add)
                    ExecuteInsertDb(SelectedModel);
                else if (FrmStatus == FormStatus.Edit)
                    ExecuteUpdateDb(SelectedModel);
                else
                    throw new Exception(String.Format(Properties.Resources.ERR_UNKNOWN, ErrCode.UnknownFormStatus));

                RefreshDatagrid((View.DgvPaging.CurrentPage - 1) * View.DgvPaging.MaxRecords, View.DgvPaging.MaxRecords);
                FrmStatus = FormStatus.Normal;
            });
        }

        protected virtual void Btn_Edit_Click(object sender, EventArgs e)
        {
            FrmStatus = FormStatus.Edit;
        }

        protected virtual void Btn_Add_Click(object sender, EventArgs e)
        {
            FrmStatus = FormStatus.Add;
            SelectedModel = new TableModel();
            View.BindModelToView(SelectedModel);
        }

        protected virtual void RefreshDatagrid(int pageOffset, int maxRecords)
        {
            SafeExecuteAction(() =>
            {
                View.DgvPaging.DataSource = GetGridPage(pageOffset, maxRecords);              
            });
        }

        protected virtual object GetGridPage(int pageOffset, int maxRecords)
        {
            return DbAccess.GetPage(pageOffset, maxRecords, GetSearchCols().ToList(), View.Tb_Search.Text);
        }

        protected virtual IEnumerable<string> GetSearchCols()
        {
            for (int i = 0; i < View.DgvPaging.DataGridView.ColumnCount; i++)
            {
                if (View.DgvPaging.DataGridView.Columns[i].Visible)
                    yield return View.DgvPaging.DataGridView.Columns[i].Name;
            }
        }

        protected virtual void SetFormStatus(FormStatus status)
        {
            frmStatus = status;
            switch (frmStatus)
            {
                case FormStatus.Normal:
                    View.Btn_Add.Enabled = true;
                    View.Btn_Edit.Enabled = true;
                    View.Btn_Save.Enabled = false;
                    View.Btn_Delete.Enabled = true;
                    View.DgvPaging.Enabled = true;
                    View.Tb_Search.Enabled = true;
                    View.Details_Panel.Enabled = false;
                    View.Btn_Cancel.Enabled = false;
                    break;
                case FormStatus.Edit:
                    View.Btn_Add.Enabled = false;
                    View.Btn_Edit.Enabled = false;
                    View.Btn_Save.Enabled = true;
                    View.Btn_Delete.Enabled = false;
                    View.DgvPaging.Enabled = false;
                    View.Tb_Search.Enabled = false;
                    View.Details_Panel.Enabled = true;
                    View.Btn_Cancel.Enabled = true;
                    break;
                case FormStatus.Add:
                    View.Btn_Add.Enabled = false;
                    View.Btn_Edit.Enabled = false;
                    View.Btn_Save.Enabled = true;
                    View.Btn_Delete.Enabled = false;
                    View.DgvPaging.Enabled = false;
                    View.Tb_Search.Enabled = false;
                    View.Details_Panel.Enabled = true;
                    View.Btn_Cancel.Enabled = true;
                    break;
            }
        }

        private void SafeExecuteAction(Action a)
        {
            try
            {
                a();
            }
            catch (Exception ex)
            {
                Logger.LogHelper.Logger.Error(ex);
                MyMessageBox.ShowException(View, ex);
            }
        }

    }
}
