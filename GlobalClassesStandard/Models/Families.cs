using DataLayerHelper.Attributes;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("Families")]
    public class Families : ModelBase
    {
        [IgnoredProperty]
        public Dictionary<int, string> LangToName { get; set; }
        public string Code{ get; set; }
    }
}
