using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required]
        public string numberPhone { get; set; }
        [Required]
        //[RegularExpression(@"^([\w\.\-]+}@[\w\-]+)((\.(\w{2,3})+)$", ErrorMessage ="invalid email format")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string AvatarPath { get; set; }
        public int idDistrict { get; set; }
        public string idProvince { get; set; }
        public string idWard { get; set; }
    }
}
