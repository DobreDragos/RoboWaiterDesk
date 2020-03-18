using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class FamiliesDE : DataBase<Families>, IFamiliesDE
    {
        public FamiliesDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
