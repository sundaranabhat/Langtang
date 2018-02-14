using Langtang.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langtang.DataAccessLayer.Service
{
    public interface IPersonnalService
    {
        List<PersonnalModel> List(string searchText);
        PersonnalModel GetDetailById(int id);
        void Insert(PersonnalModel model);
        void Update(PersonnalModel model);
    }
}
