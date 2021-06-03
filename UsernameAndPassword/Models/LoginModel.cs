using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsernameAndPassword.Models
{
    public class LoginModel
    {
        [Key]
        public String UserName{ get; set; }

        [Required]
        public String Password { get; set; }
        public virtual LoginModel Loginmodel { get; set; }
    }
}
