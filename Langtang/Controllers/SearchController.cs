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

        public ActionResult ViewSearch()
        {
            var modelList = new ViewList();
            modelList.listView = new ViewPersonnalBALCtrl().GetList();
            return View(modelList);
        }

        public ActionResult Detail(int id)
        {

            var bal = new ViewPersonnalBALCtrl();
            var model = new ViewPersonnalModel();
            model = bal.JPasPersonnal(id);
            ViewBag.FirstName = model.FirstName;
            
            return View(model);
        }


    }
}