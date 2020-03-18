using DataLayerHelper.Classes;
using DataLayerHelper.Models;
using Logger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SqlLite
{
    public class SqlConnectorManager
    {
        private SQLiteConnection sqlCon;
        private bool conOpen = false;
        private bool transactionInProgress = false;

        /// <summary>
        /// Must be the first thing called when using this singletone
        /// </summary>
        /// <param name="dbPath">The path to the database</param>
        public void InitializeConnection(string dbPath)
        {
             sqlCon = new SQLiteConnection("Data Source=" + dbPath + ";Version=3;New=False;Compress=True;");
        }

        public IDbTransaction BeginTransaction()
        {
            //LogHelper.Logger.Info("Beginning transaction");

            OpenConnection();
            transactionInProgress = true;
            return sqlCon.BeginTransaction();
        }

        public void CommitTransaction(IDbTransaction trans)
        {
            //LogHelper.Logger.Info("Commiting transaction");

            trans.Commit();
            transactionInProgress = false;
            CloseConnection();
        }
        /// <summary>
        /// Open a connection if one does not exist already.
        /// </summary>
        /// <returns>True if connection was open, false if there was already a connection</returns>
        private bool OpenConnection()
        {
            if (conOpen)
                return false;
            sqlCon.Open();
            conOpen = true;
            return true;
        }

        private bool CloseConnection()
        {
            if (transactionInProgress || !conOpen)
                return false;
            sqlCon.Close();
            conOpen = false;
            return true;
        }

        public int ExecuteQueryWithSelect(IDbCommand aSqlSelectCommand)
        {
            int res = -1;
            try
            {
                OpenConnection();
                aSqlSelectCommand.Connection = sqlCon;
                res = System.Convert.ToInt32(aSqlSelectCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                LogHelper.Logger.Error(ex);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return res;
        }

        public bool ExecuteQueryListInTransaction(List<IDbCommand> aSqlCommandList)
        {
            bool res = false;
            IDbTransaction transaction = null;
            try
            {
                sqlCon.Open();
                transaction = sqlCon.BeginTransaction();
                //run each command from the list
                foreach (IDbCommand currentCommand in aSqlCommandList)
                {
                    currentCommand.Connection = sqlCon;
                    currentCommand.ExecuteNonQuery();
                }

                transaction.Commit();
                res = true;
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                res = false;
                throw ex;
            }
            finally
            {
                transaction.Dispose();
                sqlCon.Close();
            }
            return res;
        }

        public bool ExecuteQuery(IDbCommand sqlCommand)
        {
            bool res = false;
            //LogHelper.Logger.Info("Executing query : " + sqlCommand.CommandText);
            try
            {
                OpenConnection();

                sqlCommand.Connection = sqlCon;
                sqlCommand.ExecuteNonQuery();

                res = true;
            }
            catch (Exception ex)
            {
                res = false;
                LogHelper.Logger.Error(ex);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }

            return res;
        }

        public List<T> ExecuteSelectAllQuerry<T>(IDbCommand command ) where T : IModelBase, new()
        {
            List<T> retList = new List<T>();
            var props = SqlHelper.GetProperties(typeof(T));
            try
            {
                command.Connection = sqlCon;
                OpenConnection();
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T aux = new T();
                        aux = CreateModel<T>(props, reader);
                        retList.Add(aux);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Logger.Error(ex);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return retList;
        }

        public T ExecuteSelectQuery<T>(IDbCommand command) where T : IModelBase, new()
        {
            T model = new T();
            try
            {
                command.Connection = sqlCon;
                OpenConnection();
                using (IDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        model = CreateModel<T>(SqlHelper.GetProperties(typeof(T)), reader);
                    }
                    else
                        model = default(T);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Logger.Error(ex);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return model;
        }
        private T CreateModel<T>(List<PropertyInfo> properties, IDataReader reader) where T : IModelBase, new()
        {
            PropertyInfo lastPropertyRead = null;
            T model = new T();
            try
            {
                foreach (var prop in properties)
                {
                    var value = reader[SqlHelper.GetPropertyDBFieldName(prop)];
                    lastPropertyRead = prop;
                    prop.SetValue(model, value == DBNull.Value ? null : value, null);
                }
            }
            catch (Exception e)
            {
                string err = e.Message + " " + string.Format("### Error when trying to create model {0} on property {1} ###", typeof(T).Name, lastPropertyRead.Name);
                throw new Exception(err);
            }
            return model;
        }

        public List<IDbCommand> GetUpdateCommandSteps(string dbStepFile)
        {
            List<IDbCommand> retList = new List<IDbCommand>();
            foreach (var step in DataLayerHelper.Helper.GetDbSteps(dbStepFile))
            {
                retList.Add(new SQLiteCommand(step));
            }
            
            return retList;
        }
    }
}
