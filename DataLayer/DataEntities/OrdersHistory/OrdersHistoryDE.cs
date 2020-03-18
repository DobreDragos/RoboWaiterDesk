using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class OrdersHistoryDE : DataBase<OrdersHistory>, IOrdersHistoryDE
    {
        public OrdersHistoryDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
