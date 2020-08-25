using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercise.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace exercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        //SqlConnection connectionString = new SqlConnection(@"Data Source=hoang\\sqlexpress;Database=CustomerDatabase;Trusted_Connection=True");

        public HomeController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Users = userManager.Users;
            return View();
        }
        //public IActionResult Index()
        //{
        //    var users = userManager.Users;
        //    var model = new List<User>();
        //    model = users.Select(u => new User()
        //    {
        //        City = u.,
        //        Province = u.Id,
        //        Ward = u.Email

        //    }).ToList();
        //    return View(model);
        //}
        //public ActionResult List()
        //{
        //    connection.Open();
        //    string query = "SELECT * FROM Contact";

        //    var command = new SqlCommand(query, connection);
        //    var dr = command.ExecuteReader();
        //    var model = new List<Contact>();

        //    while (dr.Read())
        //    {
        //        var contact = new Contact();

        //        contact.Id = dr.GetInt32(0);
        //        contact.FirstName = dr.GetString(1);
        //        contact.Lastname = dr.GetString(2);
        //        contact.Email = dr.GetString(3);
        //        contact.Phone = dr.GetString(4);

        //        model.Add(contact);
        //    }

        //    connection.Close();

        //    return View(model);
        //}
    }
}
