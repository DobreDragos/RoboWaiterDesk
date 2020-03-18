using DataLayerHelper.Attributes;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("OrderItemsHistory")]
    public class OrderItemsHistory : ModelBase
    {
        public long IdOrder{ get; set; }
        public long IdProduct { get; set; }
        public int Quantity { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }
    }
}
