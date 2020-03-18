using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class LanguagesDE : DataBase<Languages>, ILanguagesDE
    {
        public LanguagesDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
