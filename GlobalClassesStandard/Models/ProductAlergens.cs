using DataLayerHelper.Attributes;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("ProductAlergens")]
    public class ProductAlergens : ModelBase
    {
        public long IdProduct { get; set; }
        public long IdAlergen { get; set; }
    }
}
