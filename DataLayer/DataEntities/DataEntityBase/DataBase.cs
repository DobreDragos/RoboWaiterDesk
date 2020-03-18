using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerHelper.Models;
using DataLayerHelper.Extensions;
using DataLayerHelper.Enums;
using DataLayerHelper.Classes;
using SqlLite;

namespace DataLayer.DataLogic
{
    public abstract class DataBase<T> where T : IModelBase, new()
    {
        private static SqlCommands sqlCommands = new SqlCommands();
        private SqlConnectorManager Connector;

        public DataBase(SqlConnectorManager sqlConManager)
        {
            this.Connector = sqlConManager;
        }

        protected string TableName { get { return SqlHelper.GetTableName<T>(); } }

        public virtual T GetById(long Id)
        {
            return Connector.ExecuteSelectQuery<T>(sqlCommands.LoadAllValuesByVariable("*", TableName, new SqlFilter(new T().IdFieldName, Id)));
        }

        public virtual long Insert(T model, bool includeId = false)
        {
            List<string> fields;
            List<object> values;
            var ignored = includeId ? null : new List<string> { "Id" };
            SqlHelper.GetModelFieldsAndValues(model, out fields, out values, ignored);
            return Connector.ExecuteQueryWithSelect(sqlCommands.InsertValuesByVariable(TableName, fields, values));
        }

        public virtual bool Update(T model)
        {
            List<string> fields;
            List<object> values;
            SqlHelper.GetModelFieldsAndValues(model, out fields, out values);
            return Connector.ExecuteQuery(sqlCommands.UpdateValuesByVariable(TableName, model.IdFieldName, model.Id, fields, values));
        }

        public virtual bool Delete(T model)
        {
            return Connector.ExecuteQuery(sqlCommands.DeleteByVariable(TableName, model.IdFieldName, model.Id));
        }

        public virtual bool DeleteAll(string what, object value)
        {
            return Connector.ExecuteQuery(sqlCommands.DeleteByVariable(TableName, what, value));
        }

        public virtual bool DeleteAllFromDb(params SqlFilter[] filters)
        {
            return Connector.ExecuteQuery(sqlCommands.DeleteAll(TableName, filters));
        }

        public virtual List<T> GetAll()
        {
            return Connector.ExecuteSelectAllQuerry<T>(sqlCommands.LoadAllValuesByVariable("*", TableName));
        }

        public virtual List<T> GetAllFromDb(params SqlFilter[] filters)
        {
            return Connector.ExecuteSelectAllQuerry<T>(sqlCommands.LoadAllValuesByVariable("*", TableName, filters));
        }

        public virtual T GetFromDb(params SqlFilter[] filters)
        {
            return Connector.ExecuteSelectQuery<T>(sqlCommands.LoadAllValuesByVariable("*", TableName, filters));
        }

        public virtual bool UpdateByValue(List<string> setWhat, List<object> setValues, long id)
        {
            return Connector.ExecuteQuery(sqlCommands.UpdateValuesByVariable(TableName, new T().IdFieldName, id, setWhat, setValues));
        }

        public virtual bool UpdateByValue(string setWhat, object setValue, string whereWhat, object whereValue)
        {
            return Connector.ExecuteQuery(sqlCommands.UpdateValuesByVariable(TableName, whereWhat, whereValue, new List<string> { setWhat }, new List<object> { setValue }));
        }

        public virtual bool UpdateByValue(string setWhat, object setValues, long id)
        {
            return UpdateByValue(new List<string> { setWhat }, new List<object> { setValues }, id);
        }

        public virtual int GetCount(List<string> searchCols = null, string searchText = "", SqlFilter[] extraParams = null)
        {
            SqlFilter[] parameters = new SqlFilter[0];
            if (searchCols != null && searchText != "")
            {
                parameters = new SqlFilter[searchCols.Count];

                for (int i = 0; i < searchCols.Count; i++)
                {
                    var op = searchCols.Count == i + 1 ? SqlLogicOperators.and : SqlLogicOperators.or;
                    parameters[i] = new SqlFilter(searchCols[i], searchText, SqlOperators.contains, op);
                }
            }
            var paramList = parameters.ToList();
            if (extraParams != null)
                paramList.AddRange(extraParams);

            return GetCount(paramList.ToArray());
        }

        public virtual int GetCount(params SqlFilter[] parameters)
        {
            return Connector.ExecuteQueryWithSelect(sqlCommands.GetCount(TableName, parameters));
        }

        public virtual object GetPage(int pageNumber, int maxRecords, List<string> searchCols = null, string searchText = "", SqlFilter[] extraParams = null)
        {
            SqlFilter[] parameters = new SqlFilter[0];
            if (searchCols != null && searchText != "")
            {
                parameters = new SqlFilter[searchCols.Count];
                for (int i = 0; i < searchCols.Count; i++)
                {
                    var op = searchCols.Count == i + 1 ? SqlLogicOperators.and : SqlLogicOperators.or;
                    parameters[i] = new SqlFilter(searchCols[i], searchText, SqlOperators.contains, op);
                }
            }
            var paramList = parameters.ToList();
            if (extraParams != null)
                paramList.AddRange(extraParams);
            return GetPage(pageNumber, maxRecords, paramList.ToArray());
        }

        public virtual object GetPage(int pageNumber, int maxRecords, params SqlFilter[] parameters)
        {
            return Connector.ExecuteSelectAllQuerry<T>(sqlCommands.LoadAllValuesByPage(TableName, pageNumber, maxRecords, parameters));
        }
    }
}
