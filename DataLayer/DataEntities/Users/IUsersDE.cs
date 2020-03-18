using DataLayer.DataLogic;
using GlobalClassesStandard.Models;

namespace DataLayerStandard.DataEntities
{
    public interface IUsersDE : IDataEntity<Users>
    {
        Users Login(string user, string pass);
    }
}