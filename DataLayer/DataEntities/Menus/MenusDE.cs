using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class MenusDE : DataBase<Menus>, IMenusDE
    {
        public MenusDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
