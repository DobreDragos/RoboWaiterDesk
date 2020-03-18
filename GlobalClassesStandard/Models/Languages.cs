using DataLayerHelper.Attributes;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("Languages")]
    public class Languages : ModelBase
    {
        public string Value { get; set; }
    }
}
