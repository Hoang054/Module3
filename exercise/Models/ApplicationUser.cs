using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required]
        [RegularExpression("(09|01[2|6|8|9])+([0-9]{8})", ErrorMessage = "Số điện thoại không đúng")]
        public string numberPhone { get; set; }
        //[Required]
        //[DataType(DataType.Password)]
        //[Display(Name = "Mật khẩu")]
        //public string Password { get; set; }
        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        //[Display(Name = "Xác nhận mật khẩu")]
        //public string ConfirmPassword { get; set; }
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
        [Required]
        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }
        //public Province Province { get; set; }
        //public Ward Ward { get; set; }
        //public District District { get; set; }
    }
}
