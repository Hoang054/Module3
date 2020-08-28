using Dapper;
using exercise.Models;
using exercise.Services;
using exercise.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.Controllers
{
    public class UserController : Controller
    {
        private ICustomerService customerService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private AppDbContext context;

        public UserController(SignInManager<ApplicationUser> signInManager, ICustomerService customerService
                                , UserManager<ApplicationUser> userManager, AppDbContext _context)
        {
            this.signInManager = signInManager;
            this.customerService = customerService;
            this.userManager = userManager;
            context = _context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Provinces = customerService.GetProvinces();
            ViewBag.Districts = customerService.GetDistricts();
            ViewBag.Wards = customerService.GetWards();
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
        //[HttpGet]
        //public IActionResult GetAllProvinces()
        //{
        //    return Ok(Province);
        //}
        public IActionResult GetProvinceAll()
        {
            return Ok(customerService.GetProvinces());
        }
        public IActionResult GetDistrictById(int id)
        {
            using(var connection = new SqlConnection("Server=hoang\\sqlexpress;Database=CustomerDatabase;Trusted_Connection=True"))
            {
                string query = "select * from districts where districts._province_id= @Id";
                var district = connection.Query<District>(query, new { Id = id});

                return Ok(district);
            }
        }
        public IActionResult GetWardById(int provinceId, int districtId)
        {
            using (var connection = new SqlConnection("Server = hoang\\sqlexpress;Database=CustomerDatabase;Trusted_Connection=True"))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@provinceId", provinceId);
                parameters.Add("@dictrictId", districtId);

                string query = "select * from wards where wards._province_id= @provinceId and wards._district_id = @dictrictId";
                var wards = connection.Query<Ward>(query, parameters);
                return Ok(wards);
            }
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Create(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    Email = model.Email,
                    UserName = model.Email,
                    FullName = model.FullName,
                    numberPhone = model.numberPhone,
                    idProvince = model.idProvince,
                    idDistrict = model.idDistrict,
                    idWard = model.idWard,
                    Address = model.Address
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user: user, isPersistent: false);
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]

        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(userName: model.Email,
                                                                password: model.Password,
                                                                isPersistent: model.RememberMe,
                                                                lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attemp");
                    if (!string.IsNullOrEmpty(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult List()
        {
            var users = userManager.Users;
            var model = new List<UserViewModel>();
            model = users.Select(r => new UserViewModel()
            {
                Address = r.Address,
                Email = r.Email,
                FullName = r.FullName,
                numberPhone = r.numberPhone,
                idProvince = r.idProvince,
                idDistrict = r.idDistrict,
                idWard = r.idWard
            }).ToList();
            foreach(UserViewModel applicationUser in model)
            {
                applicationUser.District = context.districts.Find(applicationUser.idDistrict);
                applicationUser.Province = context.provinces.Find(applicationUser.idProvince);
                applicationUser.Ward = context.wards.Find(applicationUser.idWard);
            }
            return View(model); 
        }
        public IActionResult GetList()
        {
            using (var connection = new SqlConnection("Server=hoang\\sqlexpress;Database=CustomerDatabase;Trusted_Connection=True"))
            {
                string query = "select * from AspNetUsers";
                var district = connection.Query<Customer>(query);

                return Ok(district);
            }
        }
        //public IActionResult List2()
        //{
        //    District district = new District();
        //    district._name = "sahdghsda";
        //   context.districts.Add(district);
        //    context.SaveChanges();

        //    return Ok(null);
        //}
        //public async Task<ActionResult> List(string Sorting_Order)
        //{
        //    ViewBag.SortingName = String.IsNullOrEmpty(Sorting_Order) ? "Name_Description" : "";
        //    ViewBag.SortingPhone = Sorting_Order == "Date_Enroll" ? "Date_Description" : "Date";
        //    var customers = from cus in context.Customers select cus;
        //    switch (Sorting_Order)
        //    {
        //        case "Name_Description":
        //            customers = customers.OrderByDescending(cus => cus.FullName);
        //            break;
        //        case "Date_Enroll":
        //            customers = customers.OrderBy(cus => cus.numberPhone);
        //            break;
        //        case "Date_Description":
        //            customers = customers.OrderByDescending(cus => cus.Email);
        //            break;
        //        default:
        //            customers = customers.OrderBy(cus => cus.FullName);
        //            break;
        //    }
        //    return View(await customers.AsNoTracking().ToListAsync());
        //}
    }
}
