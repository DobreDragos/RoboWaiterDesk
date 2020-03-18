using DataLayerHelper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerHelper.CustomExceptions
{
    public class PresenterException : Exception
    {
        public ExCode Ex { get; set; }
        public PresenterException(ExCode e, string msg = "") : base(msg)
        {
            this.Ex = e;
        }
    }
}
