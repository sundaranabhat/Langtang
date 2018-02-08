﻿using Langtang.DataAccessLayer.Implementation;
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
    }
}