using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WADWebsite.Models;

namespace WADWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentContext _Db;

        public HomeController(StudentContext Db)
        {
            _Db = Db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        
        public IActionResult SLists(string searchBy, string search)
        {
            if (searchBy == "Email")
            {
                return View(_Db.tbl_Student.Where(s => s.Email == search || search == null).ToList());
            }
            else
            {
                return View(_Db.tbl_Student.Where(s => s.FirstName.StartsWith(search) || search == null).ToList());

            }




        }


        public IActionResult SList()
        {
            
            try
            {
                var stdList = from a in _Db.tbl_Student
                              join b in _Db.tbl_Departments
                              on a.DepID equals b.ID
                              into Dep
                              from b in Dep.DefaultIfEmpty()

                              select new Student
                              {
                                  ID = a.ID,
                                  FirstName = a.FirstName,
                                  LastName = a.LastName,
                                  Mobile = a.Mobile,
                                  Email = a.Email,
                                  Description = a.Description,
                                  DepID = a.DepID,
                                  JoinDate = a.JoinDate,

                                  Department = b == null ? "" : b.Department

                              };
                
                return View(stdList);

            }
            
            catch (Exception ex)
            {

                return View();
            }
            
        }

        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
