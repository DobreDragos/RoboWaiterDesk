using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class MenuProductsDE : DataBase<MenuProducts>, IMenuProductsDE
    {
        public MenuProductsDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
