using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class ProductsDE : DataBase<Products>, IProductsDE
    {
        public ProductsDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }

    }
}
