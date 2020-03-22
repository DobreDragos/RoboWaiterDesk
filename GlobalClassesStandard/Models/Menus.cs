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
        public Dictionary<long, string> LangToName { get; set; }
        public decimal Price { get; set; }
        public bool Enabled { get; set; }
        public decimal Discount { get; set; }
        [IgnoredProperty]
        public Dictionary<long, string> LangToDescription { get; set; }
        [IgnoredProperty]
        public List<Products> Products { get; set; }
    }
}
