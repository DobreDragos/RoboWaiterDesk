using DataLayer.DataLogic;
using GlobalClassesStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SqlLite;
using DataLayerHelper;
using DataLayerHelper.Classes;
using DataLayerHelper.Enums;

namespace DataLayerStandard.DataEntities
{
    public class UsersDE : DataBase<Users>, IUsersDE
    {
        public UsersDE(SqlConnectorManager sqlConManager) : base(sqlConManager)
        {
        }

        public Users Login(string user, string pass)
        {
            var encryptPass = Helper.GetHash(pass);

            return base.GetFromDb(
                new SqlFilter(Helper.GetName<Users>(x => x.Password), encryptPass),
                new SqlFilter(Helper.GetName<Users>(x=> x.User), user, SqlOperators.like),
                new SqlFilter(Helper.GetName<Users>(x => x.Enabled), 1));
        }
    }
}
