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
        public ActionResult Index()
        {
            //  var id = 0;
            var model = new ViewPersonnalModel();
            // var BAL = new ViewPersonnalBALCtrl();
            //model = BAL.JPasPersonnal("");
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(string searchSCARText)
        {
            //  var id = 0;
            var model = new ViewPersonnalModel();
            var BAL = new ViewPersonnalBALCtrl();
            model = BAL.JPasPersonnal(searchSCARText);
            return View(model);
        }

    }
}