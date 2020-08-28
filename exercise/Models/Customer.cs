using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.Models
{
    public class Customer
    {
        [Required]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required]
        [RegularExpression("(09|01[2|6|8|9])+([0-9]{8})", ErrorMessage = "Số điện thoại không đúng")]
        public string numberPhone { get; set; }
        [Required]
        //[RegularExpression(@"^([\w\.\-]+}@[\w\-]+)((\.(\w{2,3})+)$", ErrorMessage ="invalid email format")]
        [DataType(DataType.EmailAddress, ErrorMessage = "invalid email format")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string AvatarPath { get; set; }
        public int idDistrict { get; set; }
        public int idProvince { get; set; }
        public int idWard { get; set; }
        [Required]
        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }
    }
}
