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
        public int id { get; set; }
        [Required]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string numberPhone { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        [Display(Name = "xác nhận mật khẩu")]
        public string ConfirmPassword { get; set; }
        public string AvatarPath { get; set; }
        [Required]
        [Display(Name = "Quận/Huyện")]
        public int idDistrict { get; set; }
        [Required]
        [Display(Name = "Tỉnh/Thành")]
        public int idProvince { get; set; }
        [Required]
        [Display(Name = "Phường/xã")]
        public int idWard { get; set; }
    }
}
