using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class OrderItemsDE : DataBase<OrderItems>, IOrderItemsDE
    {
        public OrderItemsDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
