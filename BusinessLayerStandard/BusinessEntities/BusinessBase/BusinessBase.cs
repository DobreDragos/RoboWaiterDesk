﻿using DataLayerHelper.Models;
using Logger;
using SqlLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerHelper.Classes;

namespace BusinessLayer
{
    public abstract class BusinessBase : IBusinessBase
    {
        /// <summary>
        /// Executes all that happens in action inside a transaction
        /// </summary>
        /// <param name="action">the action that will be executed inside a transaction</param>
        /// <returns></returns>
        public void ExecuteInTransaction(Action action, SqlConnectorManager connector, params ModelBase[] models)
        {
            var ids = models.Select(x => x.Id).ToArray();
            IDbTransaction trans = null;
            try
            {
                trans = connector.BeginTransaction();
                action();
                connector.CommitTransaction(trans);
            }
            catch (Exception e)
            {
                if (trans != null)
                    trans.Rollback();
                for (int i=0;i<models.Length;i++)
                {
                    models[i].Id = ids[i];
                }
                LogHelper.Logger.Error(e);
                throw e;
            }
        }

        public int GetCount(params SqlFilter[] parameters)
        {
            throw new NotImplementedException();
        }

        public int GetCount(List<string> searchCols = null, string searchText = "", SqlFilter[] parameters = null)
        {
            throw new NotImplementedException();
        }

        public object GetPage(int pageOffset, int maxRecords, List<string> searchCols = null, string searchText = "", SqlFilter[] parameters = null)
        {
            throw new NotImplementedException();
        }

        public object GetPage(int pageOffset, int maxRecords, params SqlFilter[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
