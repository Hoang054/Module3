using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
        public string Address { get; set; }
        public string AvatarPath { get; set; }
        public int idDistrict { get; set; }
        public string idProvince { get; set; }
        public string idWard { get; set; }
    }
}
