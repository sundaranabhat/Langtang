using Langtang.BusinessAccessLayer;
using Langtang.DataAccessLayer;
using Langtang.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Langtang.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ViewSearch()       {

            var modelList = new List<ViewPersonnalModel>();
            modelList = new ViewPersonnalBALCtrl().GetList();
            return Json(modelList, JsonRequestBehavior.AllowGet);
        }
    }
}