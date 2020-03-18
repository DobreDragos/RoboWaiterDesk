using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class TablesDE : DataBase<Tables>, ITablesDE
    {
        public TablesDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
