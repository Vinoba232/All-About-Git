using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UsernameAndPassword.Models;

namespace UsernameAndPassword.Services
{

    public class LoginManager : IRepo<LoginModel>
    {
        private readonly RegistrationContext _context;

        public LoginManager()
        {

        }
        

        public LoginManager(RegistrationContext context)
        {   
           _context = context;
           
        }
        public bool Login(LoginModel T)
        {
            try
            {
                LoginModel user = _context.Logins.SingleOrDefault(u => u.UserName == T.UserName);
                if (user.Password == T.Password)
                    return true;
            }
            catch (Exception)
            {

                return false;
            }
            return false;
        }
            
        public bool Register(LoginModel t)
        {
            try
            {
                _context.Logins.Add(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
          
        }

       
    }
}
