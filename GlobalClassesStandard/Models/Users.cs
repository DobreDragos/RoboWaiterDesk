using DataLayerHelper.Attributes;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("Users")]
    public class Users:ModelBase
    {
        public string Password { get; set; }
        public string User { get; set; }
        public bool Enabled { get; set; }
        public int Role { get; set; }
    }
}
