using exercise.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        //SqlConnection connectionString = new SqlConnection(@"Data Source=hoang\\sqlexpress;Database=CustomerDatabase;Trusted_Connection=True");

        public UserController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Users = userManager.Users;
            return View();
            //var users = userManager.Users;
            //var model = new List<User>();
            //model = users.Select(u => new User()
            //{
            //    City = u.idProvince,
            //    District = u.idDistrict,
            //    Ward = u.idWard

            //}).ToList();
            //return View(model);
        }
    }
}
