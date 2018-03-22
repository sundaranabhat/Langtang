using Langtang.DataAccessLayer.Implementation;
using Langtang.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Langtang.BusinessAccessLayer
{
    public class ViewPersonnalBALCtrl
    {
        public List<ViewPersonnalModel> GetList()
        {
            var DAL = new ViewPersonnalCtrl();
            var result = DAL.GetViewList();
            return result;
        }
        public ViewPersonnalModel JPasPersonnal(int id)
        {
            var DAL = new ViewPersonnalCtrl();
            var result = DAL.JPasPersonnal(id);
            return result;
        }
        public void InsertUpdate(ViewPersonnalModel model)
        {
            var DAL = new ViewPersonnalCtrl();
            DAL.InsertUpdate(model);
        }



       
    }
}