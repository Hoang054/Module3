using exercise.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.ViewModels
{
    public class UserViewModel : IdentityUser
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
        //[Required]
        //public string AvatarPath { get; set; }
        public Province Province { get; set; }
        public Ward Ward { get; set; }
        public District District { get; set; }
        [Display(Name = "Tỉnh/Thành")]
        public int idProvince { get; set; }
        [Display(Name = "Quận/Huyện")]
        public int idDistrict { get; set; }
        [Display(Name = "Phường xã")]
        public int idWard { get; set; }
        [Required]
        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }
    }
}
