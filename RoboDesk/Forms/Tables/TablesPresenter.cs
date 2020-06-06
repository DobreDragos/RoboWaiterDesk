using System;
using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using RoboDesk.Forms.Base;
using RoboDesk.Interfaces;
using RoboDesk.Utils;
using DataLayerStandard.DataEntities;
using DataLayerHelper.Classes;
using VIBlend.WinForms.Controls;
using System.Collections.Generic;
using DataLayerHelper.Enums;
using System.Linq;
using BusinessLayerStandard.Extensions;

namespace RoboDesk
{
    public class TablesPresenter : CrudPresenterBase<ITablesFrm, Tables>
    {
        public TablesPresenter(ITablesFrm view) : base(view)
        {
        }

        public override IDgvDbAccess DbAccess => Context.Get<ITablesDE>();

        public Dictionary<long, Dictionary<long, string>> ModelIdToNamesByLanguageDictionary;

        protected override void ExecuteDeleteDb(Tables model)
        {
            ((ITablesDE)DbAccess).Delete(model);
        }

        protected override void ExecuteInsertDb(Tables model)
        {
            var id = ((ITablesDE)DbAccess).Insert(model);
            model.Id = id;
        }

        protected override void ExecuteUpdateDb(Tables model)
        {
            ((ITablesDE)DbAccess).Update(model);
        }

    }
}
