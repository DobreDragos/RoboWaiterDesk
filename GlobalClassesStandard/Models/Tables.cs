using DataLayerHelper.Attributes;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("Tables")]
    public class Tables:ModelBase
    {
        public string Token { get; set; }
    }
}
