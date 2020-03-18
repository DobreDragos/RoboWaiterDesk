using System.Collections.Generic;
using DataLayerHelper.Classes;
using DataLayerHelper.Models;

namespace DataLayer.DataLogic
{
    public interface IDataEntity<T> : IDgvDbAccess where T : IModelBase, new()
    {
        bool Delete(T model);
        List<T> GetAll();
        List<T> GetAllFromDb(params SqlFilter[] filters);
        T GetById(long Id);
        long Insert(T model, bool includeId = false);
        bool Update(T model);
        bool UpdateByValue(string setWhat, object setValues, long id);
        bool UpdateByValue(List<string> setWhat, List<object> setValues, long id);
        bool UpdateByValue(string setWhat, object setValue, string whereWhat, object whereValue);
        bool DeleteAll(string what, object value);
        bool DeleteAllFromDb(params SqlFilter[] filters);
    }
}