using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;

namespace DataLayerStandard.DataEntities
{
    public class PrinterBillsHistoryDE : DataBase<PrinterBillsHistoryModel>, IPrinterBillsHistoryDE
    {
        public PrinterBillsHistoryDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }
    }
}
