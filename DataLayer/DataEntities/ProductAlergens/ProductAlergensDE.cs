using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class ProductAlergensDE : DataBase<ProductAlergens>, IProductAlergensDE
    {
        public ProductAlergensDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
