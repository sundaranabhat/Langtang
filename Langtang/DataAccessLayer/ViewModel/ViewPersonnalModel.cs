using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Langtang.DataAccessLayer.ViewModel
{
    public class ViewPersonnalModel
    {
        //Constructor
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


        public string SSN { get; set; }
        public int RateId { get; set; }
        public int RankId { get; set; }
        public int GradeId { get; set; }
        public int CategoryId { get; set; }
        public int ClassId { get; set; }
        public int EligibilityId { get; set; }
        public int InvestigationTypeId { get; set; }
        public int AdjucatingAgencyId { get; set; }

        public string PlaceOfBirthState { get; set; }
        public string PlaceOfBirthCountry { get; set; }
        public int  CACExpires { get; set; }
        public string Notes { get; set; }
        public string BilletNumber { get; set; }
        public DateTime NDS { get; set; }
        public DateTime AttestationDate { get; set; }
        public string SCI_Access { get; set; }
        public DateTime EligibilityGranted { get; set; }
        public DateTime InvestigationCloseDate { get; set; }
        public DateTime ClearanceExpirationDate { get; set; }
        public DateTime OngoingInvestigationDate { get; set; }
        public int WaiverID { get; set; }
        public int ConditionalId { get; set; }
        public DateTime OutProcessDate { get; set; }
        public int DebriefTypeId { get; set; }


        public bool isSelected { get; set; }
        public bool isTSSelected { get; set; }
        public bool isSecretSelected { get; set; }
        public bool isSapSelected { get; set; }

        public bool isSIselected { get; set; }
        public bool isTKselected { get; set; }
        public bool isGselected { get; set; }
        public bool isHCSselected { get; set; }
        public bool isHSLselected { get; set; }
        public bool isELselected { get; set; }

    }

    public class ViewList
    {
        public ViewList()
        {
            this.listView = new List<ViewPersonnalModel>();
            this.PersonnalList = new List<PersonnalModel>();

        }
        public List<ViewPersonnalModel> listView { get; set; }
        public List<PersonnalModel> PersonnalList { get; set; }
    }
    

}