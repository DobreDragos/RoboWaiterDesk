using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboDesk.Interfaces
{
    public interface ILoginFrm : IFormBase
    {
        string User { get; set; }
        string Pass { get; set; }
    }
}
