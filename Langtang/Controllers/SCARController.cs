using Langtang.BusinessAccessLayer;
using Langtang.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Langtang.Controllers
{
    public class SCARController : Controller
    {
        // GET: SCAR
        public ActionResult Index(int id)
        {
            //  var id = 0;
            var model = new ViewPersonnalModel();
            var BAL = new ViewPersonnalBALCtrl();
            model = BAL.JPasPersonnal(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Save(ViewPersonnalModel model)
        {
            var BAL = new ViewPersonnalBALCtrl();
            BAL.Insert(model);
            return View(model);
        }

    }
}