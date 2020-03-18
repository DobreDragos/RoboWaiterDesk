using BusinessLayer;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Utils
{
    public static partial class Globals
    {
        public static IContext Context { get; private set; }
        public static Users CurrentUser { get; set; }
        static Globals()
        {
            Context = new Context(RoboDesk.Properties.Settings.Default.DbLocation);
        }
        public static string AppName => "RoboWaiter";
    }
}
