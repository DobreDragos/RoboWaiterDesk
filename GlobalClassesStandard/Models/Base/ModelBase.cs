using DataLayerHelper.Attributes;
using DataLayerHelper.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerHelper.Models
{
    public abstract class ModelBase : IModelBase
    {
        [PrimaryKey]
        public long Id { get; set; }

        [IgnoredProperty]
        public string IdFieldName { get { return "Id"; } }

        [IgnoredProperty]
        public bool IsNew
        {
            get
            {
                return Id <= 0;
            }
        }
    }
}
