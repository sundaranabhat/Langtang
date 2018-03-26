using Langtang.DataAccessLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Langtang.DataAccessLayer.ViewModel;
using Langtang.DataAccessLayer.SSO_Database;

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

                var viewData = entities.vPersonnels.OrderBy(x => x.FirstName).ToList();
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

            //call [spGetProfile] procedure

            var model = new ViewPersonnalModel();

            using (var pahadentity = new PahadDbEntities())
            {
                var resultProcedure = pahadentity.spGetProfile1(id).FirstOrDefault();
                model.ProfileID = resultProcedure.ProfileID;
                model.FirstName = resultProcedure.FirstName;
                model.MiddleName = resultProcedure.MiddleName;
                model.LastName = resultProcedure.LastName;
                model.SSN = resultProcedure.SSN;
            }

            if (model != null)
            {
                if (model.NonSCIAccesses != null)
                {
                    if (model.NonSCIAccesses.Contains("TS"))
                    {
                        model.isTSSelected = true;
                        model.isSecretSelected = true;
                    }
                    else if (model.NonSCIAccesses.Contains("SECRTET"))
                    {
                        model.isSecretSelected = true;
                    }
                    model.isSapSelected = true;

                }
                if (model.SCIAccesses != null)
                {
                    if (model.SCIAccesses.Contains("HCS"))
                    {
                        model.isHCSselected = true;
                    }
                    if (model.SCIAccesses.Contains("TK"))
                    {
                        model.isTKselected = true;
                    }
                    if (model.SCIAccesses.Contains("HSL"))
                    {
                        model.isHSLselected = true;
                    }
                }
                if (model.PersonalCategory == "AA")
                {

                }
                else
                {

                }
            }
            return model;
        }

        public void InsertUpdate(ViewPersonnalModel model)
        {
            var personnalImplementation = new PersonnalImplemention();
            personnalImplementation.InsertUpdate(model);
        }
    }
}