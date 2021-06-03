using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UsernameAndPassword.Models
{
    public class Employee
    {
        [Key]
        public  int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        [ForeignKey("Username")]
        public string Username { get; set; }
        public virtual LoginModel Loginmodel { get; set; }

        public virtual Employee employee { get; set; }



    }
}
