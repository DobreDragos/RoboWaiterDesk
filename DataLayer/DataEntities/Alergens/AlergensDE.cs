using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class AlergensDE : DataBase<Alergens>, IAlergensDE
    {
        public AlergensDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
