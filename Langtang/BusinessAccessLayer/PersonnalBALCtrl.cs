using Langtang.DataAccessLayer.Implementation;
using Langtang.DataAccessLayer.Service;
using Langtang.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Langtang.BusinessAccessLayer
{
    public class PersonnalBALCtrl
    {
        private IPersonnalService personnalService;

        public PersonnalBALCtrl()
        {
            personnalService = new PersonnalImplemention();
        }

        public PersonnalModel Detail(int id)
        {
            var model = new PersonnalModel();
            model = personnalService.GetDetailById(id);
            return model;
        }

        public List<PersonnalModel> GetList(int id)
        {
            var model = new ViewList();
            model.PersonnalList = personnalService.List(id);
            return model.PersonnalList;
        }


        public void Insert(PersonnalModel model)
        {
            personnalService.Insert(model);
        }


        public void Update(PersonnalModel model)
        {
            personnalService.Update(model);
        }
    }
}
