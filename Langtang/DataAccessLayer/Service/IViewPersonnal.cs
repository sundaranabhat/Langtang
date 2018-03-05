using Langtang.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langtang.DataAccessLayer.Service
{
    public interface IViewPersonnal
    {
        List<ViewPersonnalModel> GetViewList();
        ViewPersonnalModel JPasPersonnal(int id);
    }
}
