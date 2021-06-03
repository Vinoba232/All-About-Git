using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UsernameAndPassword.Models
{
    public class RegistrationContext:DbContext
    {
        public RegistrationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<LoginModel> Logins { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Salary> Salaries{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<LoginModel>().HasData(
                new LoginModel() { UserName="Hema" , Password="1234" });
        }
      
    }
}
