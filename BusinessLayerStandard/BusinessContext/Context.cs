using BusinessLayer;
using DataLayer.DataLogic;
using DataLayerStandard.DataEntities;
using DataLayerHelper.Classes;
using DataLayerHelper.Models;
using SqlLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Context : IContext
    {
        private Dictionary<Type, IDgvDbAccess> DbAccess;
        private static IEnumerable<Type> ExistingIDataBase = Assembly.GetExecutingAssembly().GetTypes()
                                .Where(t => t.IsAbstract == false && t.GetInterfaces().Contains(typeof(IDgvDbAccess)));
        private static IEnumerable<Type> ExistingIBusinessBase = Assembly.GetExecutingAssembly().GetTypes()
                                .Where(t => t.IsAbstract == false && t.GetInterfaces().Contains(typeof(IBusinessBase)));
 
        public Context(string dbLocation)
        {
            SqlConnectorManager sqlCon = null;
            sqlCon = new SqlConnectorManager();
            sqlCon.InitializeConnection(dbLocation);

            DbAccess = new Dictionary<Type, IDgvDbAccess>
            {
                { typeof(IPrinterBillsHistoryDE), new PrinterBillsHistoryDE(sqlCon) },
                { typeof(IAlergensDE), new AlergensDE(sqlCon) },
                { typeof(IFamiliesDE), new FamiliesDE(sqlCon) },
                { typeof(IMenuProductsDE), new MenuProductsDE(sqlCon) },
                { typeof(IOrderItemsDE), new OrderItemsDE(sqlCon) },
                { typeof(IOrderItemsHistoryDE), new OrderItemsHistoryDE(sqlCon) },
                { typeof(IOrdersDE), new OrdersDE(sqlCon) },
                { typeof(IOrdersHistoryDE), new OrdersHistoryDE(sqlCon) },
                { typeof(IProductAlergensDE), new ProductAlergensDE(sqlCon) },
                { typeof(IProductsDE), new ProductsDE(sqlCon) },
                { typeof(ITablesDE), new TablesDE(sqlCon) },
                { typeof(IUsersDE), new UsersDE(sqlCon) },
                 { typeof(ILanguagesDE), new LanguagesDE(sqlCon) },
                   { typeof(INamesDE), new NamesDE(sqlCon) },
                 { typeof(IMenusDE), new MenusDE(sqlCon) }
            };
        }

        /// <summary>
        /// Gets Transaction component
        /// </summary>
        /// <typeparam name="T">DbAccess you want to get</typeparam>
        /// <returns></returns>
        public T Get<T>() where T: IDgvDbAccess
        {
            return (T)DbAccess[typeof(T)];
        }
    }
}
