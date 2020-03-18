using DataLayerHelper.Enums;
using DataLayerHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace RoboDesk.Interfaces
{
    /// <summary>
    /// Interface that contains base methods that most forms must implement.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICrudView<T> : IFormBase where T: IModelBase
    {
        void SetFormStatus(FormStatus formStatus);

        void RefreshDataGrid(List<T> list);

        void TranslateDataGrid(ResourceManager res);

        bool SelectDataGridItem(string selectedName = "");
    }
}
