using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BackendLatihanBlazor.Models;

namespace BackendLatihanBlazor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {

        public List<Employee> Employees { get; set; } = new List<Employee>();

        [HttpGet]
        public IEnumerable<Employee> Get(){
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Erick",
                LastName="Kurniawan",
                Email="erick@actual-training.com",
                DateOfBirth = new DateTime(1999,10,5),
                Gen = Gender.Male,
                Depart = new Department{DepartmentId=1,DepartmentName="IT"},
                PhotoPath = "images/erick.jpg"
            };
            Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Keren",
                LastName="Kezia",
                Email="kezia@gmail.com",
                DateOfBirth = new DateTime(1999,10,10),
                Gen = Gender.Female,
                Depart = new Department{DepartmentId=2,DepartmentName="Desain"},
                PhotoPath = "images/kezia.jpg"
            };
            Employee e3 = new Employee{
                EmployeeId=3,
                FirstName="William",
                LastName="Theodorus",
                Email="william@gmail.com",
                DateOfBirth = new DateTime(1999,10,8),
                Gen = Gender.Male,
                Depart = new Department{DepartmentId=3,DepartmentName="Manager"},
                PhotoPath = "images/theo.jpg"
            };
            Employees = new List<Employee>{e1,e2,e3};

            return Employees;
        }
    }
}