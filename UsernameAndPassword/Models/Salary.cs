using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UsernameAndPassword.Models
{
    public class Salary
    { 
        [Key]
        public int Salary_id { get; set; }
        public float EmployeeSalary{ get; set; }
        [ForeignKey("id")]
        public string EmployeeId { get; set; }
        public DateTime Date { get; set; }

        public virtual Employee employee { get; set; }

    }
}
