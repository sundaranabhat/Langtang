using Langtang.BusinessAccessLayer;
using Langtang.DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Langtang.Controllers
{
    public class PersonnalController : Controller
    {
        // GET: Personnal
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Search(int id)
        {
            if (id != 0)
            {
                var bal = new PersonnalBALCtrl();
                var model = new ViewList();
                model.PersonnalList = bal.GetList(id);
                return View(model);
            }
            else
            {
                return View("Index");
            }

        }

        public ActionResult Detail(int id)
        {

            var bal = new PersonnalBALCtrl();
            var model = new PersonnalModel();
            model = bal.Detail(id);
            ViewBag.SSN = model.SSN;
            return View(model);
        }

        public ActionResult Create()
        {
            var model = new PersonnalModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(PersonnalModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var bal = new PersonnalBALCtrl();
                    bal.Insert(model);
                    return RedirectToAction("Index", "Personnal");

                }
                else
                {
                    return View(model);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult Edit(int id)
        {
            var model = new PersonnalModel();
            var bal = new PersonnalBALCtrl();
            model = bal.Detail(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(PersonnalModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var bal = new PersonnalBALCtrl();
                    bal.Update(model);
                    return RedirectToAction("Index", "Personnal");
                }
                else
                {
                    return View();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}