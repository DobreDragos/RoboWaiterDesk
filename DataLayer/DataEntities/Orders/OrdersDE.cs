﻿using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class OrdersDE : DataBase<Orders>, IOrdersDE
    {
        public OrdersDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
