using Langtang.DataAccessLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Langtang.DataAccessLayer.ViewModel;
using System.Data.Entity;
using Langtang.DataAccessLayer.SSO_Database;

namespace Langtang.DataAccessLayer.Implementation
{
    public class PersonnalImplemention : IPersonnalService
    {
        public PersonnalModel GetDetailById(int id)
        {
            using (var entity = new HimalDbEntities())
            {
                var personnalValue = entity.Personnel1.Where(x => x.ID == id).FirstOrDefault();

                var model = new PersonnalModel();
                if (personnalValue != null)
                {
                    model.ID = personnalValue.ID;
                    model.LASTNAME = personnalValue.LASTNAME;
                    model.PLACEOFBIRTH = personnalValue.PLACEOFBIRTH;
                    model.FIRSTNAME = personnalValue.FIRSTNAME;
                    model.GENDER = personnalValue.GENDER;
                    model.DATEOFBIRTH = personnalValue.DATEOFBIRTH;
                    model.DODID = personnalValue.DODID;
                }
                return model;

            }

        }

        public void Insert(PersonnalModel model)
        {
            if (Insert_SSO(model))
            {
                using (var entity = new HimalDbEntities())
                {
                    var tableRow = new Personnel1();
                    tableRow.FIRSTNAME = model.FIRSTNAME;
                    tableRow.LASTNAME = model.LASTNAME;
                    tableRow.DODID = model.DODID;
                    tableRow.GENDER = model.GENDER;
                    tableRow.EMAIL = model.EMAIL;
                    tableRow.DATEOFBIRTH = model.DATEOFBIRTH;
                    tableRow.PLACEOFBIRTH = model.PLACEOFBIRTH;
                    entity.Personnel1.Add(tableRow);
                    entity.SaveChanges();
                }
            }
        }
        public bool Insert_SSO(PersonnalModel model)
        {
            var success = false;
            using (var entity = new PahadDbEntities())
            {
                var tableRow = new Personnel();
                tableRow.FirstName = model.FIRSTNAME;
                tableRow.LastName = model.LASTNAME;
                entity.Personnels.Add(tableRow);
                entity.SaveChanges();
                success = true;
            }
            return success;
        }

        public List<PersonnalModel> List(int id)
        {

            using (var entity = new HimalDbEntities())
            {
                // var personnalList = entity.Personnels.ToList();
                var ListModel = new List<PersonnalModel>();
                var personnalList = entity.Personnel1.Where(x => x.ID == id).ToList(); // filter according to firstname or last name


                foreach (var item in personnalList)
                {
                    var model = new PersonnalModel();
                    model.ID = item.ID;
                    model.FIRSTNAME = item.FIRSTNAME;
                    model.LASTNAME = item.LASTNAME;
                    model.EMAIL = item.EMAIL;
                    model.DODID = item.DODID;
                    model.DATEOFBIRTH = item.DATEOFBIRTH;
                    model.GENDER = item.GENDER;
                    ListModel.Add(model);
                }
                return ListModel;
            }
        }

        public void Update(PersonnalModel model)
        {
            using (var entity = new HimalDbEntities())
            {
                var editData = entity.Personnel1.Where(x => x.DODID == model.DODID).FirstOrDefault();
                editData.FIRSTNAME = model.FIRSTNAME;
                editData.LASTNAME = model.LASTNAME;
                editData.DATEOFBIRTH = model.DATEOFBIRTH;
                editData.DODID = model.DODID;
                editData.EMAIL = model.EMAIL;
                editData.GENDER = model.GENDER;
                entity.Entry(editData).State = EntityState.Modified;
                entity.SaveChanges();
            }
        }
    }
}