//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Langtang.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personnel2
    {
        public int ProfileID { get; set; }
        public string SMORelationship { get; set; }
        public string Eligibility { get; set; }
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
        public int EventID { get; set; }
    }
}
