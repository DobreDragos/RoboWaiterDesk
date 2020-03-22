using DataLayerHelper.Attributes;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("Translations")]
    public class Translations : ModelBase
    {
        public long ObjectTypeId { get; set; }
        public long LanguageId { get; set; }
        public long ObjectId { get; set; }
        public string Name { get; set; }
    }
}
