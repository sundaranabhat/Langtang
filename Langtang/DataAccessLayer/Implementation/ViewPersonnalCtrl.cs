using Langtang.DataAccessLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Langtang.DataAccessLayer.ViewModel;

namespace Langtang.DataAccessLayer.Implementation
{
    public class ViewPersonnalCtrl : IViewPersonnal
    {
        public List<ViewPersonnalModel> GetViewList()
        {
            var modelList = new List<ViewPersonnalModel>();
            using (var entities = new HimalDbEntities())
            {
                //var viewData = from v in entities.vPersonnels
                //                 select v;

                var viewData = entities.vPersonnels.ToList();
                foreach (var item in viewData)
                {
                    var model = new ViewPersonnalModel();
                    model.ProfileID = item.ProfileID;
                    model.FirstName = item.FirstName;
                    model.LastName = item.LastName;
                    model.DOB = item.DOB;
                    model.eligibility = item.eligibility;
                    model.DODID = item.DODID;
                    model.InvestigationType = item.InvestigationType;
                    model.NDA = item.NDA;
                    model.NonSCIAccesses = item.NonSCIAccesses;
                    model.PersonalCategory = item.PersonalCategory;
                    model.ProfileID = item.ProfileID;
                    model.SMORelationship = item.SMORelationship;
                    model.PrevInvestigationCloseDate = item.PrevInvestigationCloseDate;
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        public ViewPersonnalModel JPasPersonnal(int id)
        {
            using (var entity = new HimalDbEntities())
            {
                var model = new ViewPersonnalModel();
                model = GetViewList().Where(x => x.ProfileID == id).FirstOrDefault();
                return model;
            }
        }
    }
}