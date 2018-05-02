using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIdemo.Models;

namespace WebAPIdemo.Controllers
{
    public class CarDetailsController : ApiController
    {
        [HttpGet]
        public IEnumerable<CarsStock> GetAllcarDetails()
        {
            CarsStock ST = new CarsStock();
            CarsStock ST1 = new CarsStock();
            List<CarsStock> li = new List<CarsStock>();

            ST.CarName = "Mercedes";
            ST.CarPrice = 40000;
            ST.CarModel = "AMD";
            ST.CarColor = "BLACK";

            ST1.CarName = "BMW ";
            ST1.CarPrice = 50000;
            ST1.CarModel = "M3";
            ST1.CarColor = "RED";

            li.Add(ST);
            li.Add(ST1);
            return li;
        }

        public IEnumerable<CarsStock> Get(int id)
        {
            CarsStock ST = new CarsStock();
            CarsStock ST1 = new CarsStock();
            List<CarsStock> li = new List<CarsStock>();
            if (id == 1)
            {

                ST.CarName = "Mercedes";
                ST.CarPrice = 40000;
                ST.CarModel = "AMD";
                ST.CarColor = "BLACK";
                li.Add(ST);
            }
            else
            {
                ST1.CarName = "BMW ";
                ST1.CarPrice = 50000;
                ST1.CarModel = "M3";
                ST1.CarColor = "RED";
                li.Add(ST1);
            }
            return li;
        }

        [HttpPost]
        public void PostCar ( int id, [FromBody] CarsStock cs)
        {

        }

        [HttpPut]
        public void PutCar ([FromBody]CarsStock cs)
        {

        }

        [HttpDelete]
        public void DeleteCar (int id)
        {

        }
    }
}
