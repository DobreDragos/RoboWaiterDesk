using DataLayerHelper.Attributes;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("Alergens")]
    public class Alergens : ModelBase
    {
        [IgnoredProperty]
        public Dictionary<int, string> LangToName { get; set; }
        public string Code{ get; set; }
    }
}
