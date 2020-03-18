using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerHelper.Attributes
{
    public class SqlTable : Attribute
    {
        private string Name { get;  set; }
        public SqlTable(string name) {

            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
