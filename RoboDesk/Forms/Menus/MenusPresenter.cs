using System;
using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using RoboDesk.Forms.Base;
using RoboDesk.Interfaces;
using RoboDesk.Utils;
using DataLayerStandard.DataEntities;
using DataLayerHelper.Classes;
using VIBlend.WinForms.Controls;

namespace RoboDesk
{
    public class MenusPresenter : CrudPresenterBase<IMenusFrm, Menus>
    {
        public MenusPresenter(IMenusFrm view) : base(view)
        {
        }

        public override IDgvDbAccess DbAccess => Context.Get<IMenusDE>();

        protected override void ExecuteDeleteDb(Menus model)
        {
            ((IMenusDE)DbAccess).Delete(model);
        }

        protected override void ExecuteInsertDb(Menus model)
        {
            ((IMenusDE)DbAccess).Insert(model);
        }

        protected override void ExecuteUpdateDb(Menus model)
        {
            ((IMenusDE)DbAccess).Update(model);
        }

        internal void EnsureLanguages(vComboBox cb)
        {
            var langs = Context.Get<ILanguagesDE>().GetAll();
            cb.DisplayMember = "Value";
            cb.ValueMember = "Id";
            cb.DataSource = langs;
        }
    }
}
