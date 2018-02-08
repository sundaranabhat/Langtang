﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Langtang.DataAccessLayer.ViewModel
{
    public class ViewPersonnalModel
    {

        public ViewPersonnalModel()
        {
        }
        public int ProfileID { get; set; }
        public string DODID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SMORelationship { get; set; }
        public string eligibility { get; set; }
        public Nullable<System.DateTime> EligibilityDate { get; set; }
        public string InvestigationType { get; set; }
        public Nullable<System.DateTime> PrevInvestigationCloseDate { get; set; }
        public string PersonalCategory { get; set; }
        public string PositionSensitivity { get; set; }
        public string Grade { get; set; }
        public string NonSCIAccesses { get; set; }
        public string SCIAccesses { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string POB { get; set; }
        public Nullable<System.DateTime> NDA { get; set; }

    }

    public class ViewList
    {
        public ViewList()
        {
            this.listView = new List<ViewPersonnalModel>();

        }
        public List<ViewPersonnalModel> listView { get; set; }

    }

}