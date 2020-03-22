using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class TranslationsDE : DataBase<Translations>, ITranslationsDE
    {
        public TranslationsDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
