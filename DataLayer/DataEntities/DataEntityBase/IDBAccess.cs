using System.Collections.Generic;
using System.Data;
using DataLayerHelper.Classes;
using DataLayerHelper.Models;
using SqlLite;

namespace DataLayer.DataLogic
{
    public interface IDgvDbAccess
    {
        int GetCount(params SqlFilter[] parameters);
        object GetPage(int pageOffset, int maxRecords, List<string> searchCols = null, string searchText = "", SqlFilter[] parameters = null);
        object GetPage(int pageOffset, int maxRecords, params SqlFilter[] parameters);
        int GetCount(List<string> searchCols = null, string searchText = "", SqlFilter[] parameters = null);
    }
}