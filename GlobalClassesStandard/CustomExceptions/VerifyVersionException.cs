using DataLayerHelper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerHelper.CustomExceptions
{
    public class VerifyVersionException : Exception
    {
        public ExCode Ex { get; set; }
        public Action UpdateAction { get; set; }
        public VerifyVersionException(ExCode e, Action updateAction = null) : base()
        {
            this.Ex = e;
            this.UpdateAction = updateAction;
        }
    }
}
