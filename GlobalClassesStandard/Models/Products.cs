using DataLayerHelper.Attributes;
using DataLayerHelper.Enums;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("Products")]
    public class Products : ModelBase
    {
        public string Code { get; set; }

        [IgnoredProperty]
        public Dictionary<long,string> LangToName { get; set; }
        public long IdFamily { get; set; }
        public decimal Price { get; set; }
        public bool Enabled { get; set; }
        public decimal Discount { get; set; }
        public DateTime? DiscountStart { get; set; }
        public DateTime? DiscountEnd { get; set; }
        public int DiscountType { get; set; }

        [IgnoredProperty]
        public string FamilyCode { get; set; }
        [IgnoredProperty]
        public Dictionary<long, string> LangToDescription { get; set; }
        [IgnoredProperty]
        public Dictionary<long, string> LangToAlergens { get; set; }
    }
}
