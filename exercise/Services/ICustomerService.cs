using exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.Services
{
    public interface ICustomerService
    {
        List<Province> GetProvinces();
        List<District> GetDistricts();
        List<Ward> GetWards();
        IEnumerable<ApplicationUser> Gets();
        ApplicationUser Create(ApplicationUser customer);
        ApplicationUser Get(int id);
    }
}
