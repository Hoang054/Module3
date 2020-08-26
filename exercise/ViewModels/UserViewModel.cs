using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.ViewModels
{
    public class UserViewModel
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
    }
}
