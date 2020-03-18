using System;
using System.Data;
using DataLayerHelper.Models;
using SqlLite;
using DataLayer.DataLogic;

namespace BusinessLayer
{
    public interface IBusinessBase : IDgvDbAccess
    {
        void ExecuteInTransaction(Action action, SqlConnectorManager connector, params ModelBase[] models);
    }
}