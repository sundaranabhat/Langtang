﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Langtang.DataAccessLayer;
using Langtang.DataAccessLayer.ViewModel;

namespace Langtang.Controllers
{
    public class UtilityController : Controller
    {
        // GET: Utility
       public JsonResult GetContactInfoOds(string searchText)
        {
            var  list = GetOdsPersonList(searchText);
            if(list != null)
            {
                return Json(list.ToArray(), JsonRequestBehavior.AllowGet);
            }

            else
            {
                return Json("", JsonRequestBehavior.AllowGet);
            }
        }

        internal static List<TestProcViewModel> GetOdsPersonList(string searchText)
        {
            using (var entiity = new HimalDbEntities())
            {
                var searchTextValue = "S";
              var list = entiity.TestProc(searchTextValue).OrderBy(x => x.DisplayName).ToList();
                var collection = new List<TestProcViewModel>();
                foreach (var item in collection)
                {
                    var model = new TestProcViewModel();
                    model.ID = item.ID;
                    model.DisplayName = item.DisplayName;
                    collection.Add(model);
                }
                return collection;
            }
        }
    }
}