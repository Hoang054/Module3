using exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.Services
{
    public class CustomerService : ICustomerService
    {
        //private List<Customer> customers;
        private readonly AppDbContext context;

        public CustomerService(AppDbContext context)
        {
            this.context = context;
        }

        public ApplicationUser Get(int id)
        {
            //return customers.FirstOrDefault(e => e.id == id);
            return context.Customers.Find(id);
        }

        public List<District> GetDistricts()
        {
            return context.districts.ToList();
        }

        public List<Province> GetProvinces()
        {
            return context.provinces.ToList();
        }

        public IEnumerable<ApplicationUser> Gets()
        {
            return context.Customers;
        }

        public List<Ward> GetWards()
        {
            return context.wards.ToList();
        }

        public ApplicationUser Create(ApplicationUser customer)
        {
            //customer.id = customers.Max(e => e.id) + 1;
            //customers.Add(customer);
            //return customer;
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }
    }
}
