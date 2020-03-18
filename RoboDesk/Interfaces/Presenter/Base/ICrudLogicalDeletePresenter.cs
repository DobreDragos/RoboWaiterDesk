using DataLayerHelper.Models;

namespace RoboDesk.Interfaces
{
    public interface ICrudLogicalDeletePresenter<T> :ICrudPresenter<T> where T: IModelBase
    {
        void SearchLogicalDeleted(bool doSearch);
    }
}