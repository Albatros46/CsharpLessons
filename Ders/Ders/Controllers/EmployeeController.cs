using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ders.Entities;

namespace Ders.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Calisanlar()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Servet",LastName="Akçadağ",CityId=46},
                new Employee{Id=2,FirstName="Ahmet",LastName="Akçadağ",CityId=47},
                new Employee{Id=3,FirstName="Akif",LastName="Akçadağ",CityId=34},
                new Employee{Id=4,FirstName="Oğuz",LastName="Akçadağ",CityId=6}
            };
        }
    }
}