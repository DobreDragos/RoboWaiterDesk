using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerHelper.Attributes
{
    public class SqlField : Attribute
    {
        private string Name { get;  set; }
        public SqlField(string name) {

            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
