using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class OrderItemsHistoryDE : DataBase<OrderItemsHistory>, IOrderItemsHistoryDE
    {
        public OrderItemsHistoryDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
