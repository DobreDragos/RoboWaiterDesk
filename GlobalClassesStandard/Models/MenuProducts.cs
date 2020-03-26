using DataLayerHelper.Attributes;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("MenuProducts")]
    public class MenuProducts : ModelBase
    {
        public long IdProduct { get; set; }
        public long IdMenu { get; set; }
        public int Quantity { get; set; }
    }
}
