using DataLayerHelper.Attributes;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalClassesStandard.Models
{
    [SqlTable("PrinterBillsHistory")]
    public class PrinterBillsHistoryModel : ModelBase
    {
        public long PosId { get; set; }

        public string Bill { get; set; }
        public long CashRegisterId { get; set; }

        public string Details { get; set; }

        public DateTime DatePrinted { get; set; }

        public int CommandType { get; set; }
        public long PrinterBillId { get; set; }
    }
}
