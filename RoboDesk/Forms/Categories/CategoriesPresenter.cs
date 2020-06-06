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
using RoboDesk.Interfaces.Categories;

namespace RoboDesk
{
    public class CategoriesPresenter : CrudPresenterBase<ICategoriesFrm, Families>
    {
        public CategoriesPresenter(ICategoriesFrm view) : base(view)
        {
        }

        public override IDgvDbAccess DbAccess => Context.Get<ITablesDE>();

        public Dictionary<long, Dictionary<long, string>> ModelIdToNamesByLanguageDictionary;

        protected override void ExecuteDeleteDb(Families model)
        {
            ((IFamiliesDE)DbAccess).Delete(model);
        }

        protected override void ExecuteInsertDb(Families model)
        {
            var id = ((IFamiliesDE)DbAccess).Insert(model);
        }

        protected override void ExecuteUpdateDb(Families model)
        {
            ((IFamiliesDE)DbAccess).Update(model);
        }

    }
}
