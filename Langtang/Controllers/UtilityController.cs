using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Langtang.DataAccessLayer;

namespace Langtang.Controllers
{
    public class UtilityController : Controller
    {
        // GET: Utility
       public JsonResult GetContactInfoOds()
        {
            List<Personnel> list = GetOdsPersonList();
            if(list != null)
            {
                return Json(list.ToArray(), JsonRequestBehavior.AllowGet);
            }

            else
            {
                return Json("", JsonRequestBehavior.AllowGet);
            }
        }

        internal static List<Personnel> GetOdsPersonList()
        {
            using (var entiity = new HimalDbEntities())
            {
                List<Personnel> list = entiity.Personnels.OrderBy(x => x.FIRSTNAME).ToList();
                return list;
            }
        }
    }
}