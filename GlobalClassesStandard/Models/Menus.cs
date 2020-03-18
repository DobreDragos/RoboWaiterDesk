using DataLayerHelper.Attributes;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("Menus")]
    public class Menus : ModelBase
    {
        public string Code { get; set; }
        [IgnoredProperty]
        public Dictionary<int, string> LangToName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Enabled { get; set; }
        public decimal Discount { get; set; }
    }
}
