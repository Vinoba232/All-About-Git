using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsernameAndPassword.Services
{
    public  interface IRepo<T>
    {
        bool Register(T t);
        bool Login(T t);

    }
}
