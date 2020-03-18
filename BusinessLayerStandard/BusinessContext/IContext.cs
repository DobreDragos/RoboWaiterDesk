using DataLayer.DataLogic;

namespace BusinessLayer
{
    public interface IContext
    {
        T Get<T>() where T : IDgvDbAccess;
    }
}