using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerHelper.Extensions;

namespace DataLayerHelper.Classes
{
    public class DbStep
    {
        public Version Version { get; set; }
        public string UpdateQuery { get; set; }
        public int Step { get { return DataLayerHelper.Helper.GetDbStepCount(UpdateQuery);  } }

        public bool IsValid(out string invalidLine)
        {
            var currentStep = 0;
            var stepFound = -1;
            invalidLine = string.Empty;
            foreach (var line in UpdateQuery.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (line.StartsWith("_GO_"))
                {
                    currentStep++;
                    string trimmedLine = line.TrimFirstOccurence("_GO_").Replace(" ", "").Replace("-", "");
                    if (!trimmedLine.StartsWith("step"))
                    {
                        invalidLine = line;
                        return false;
                    }
                    trimmedLine = trimmedLine.TrimFirstOccurence("step");

                    if (!int.TryParse(trimmedLine, out stepFound) || stepFound != currentStep)
                    {
                        invalidLine = line;
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
