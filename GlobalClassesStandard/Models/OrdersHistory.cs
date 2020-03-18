using DataLayerHelper.Attributes;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("OrdersHistory")]
    public class OrdersHistory : ModelBase
    {
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string Comments { get; set; }
    }
}
