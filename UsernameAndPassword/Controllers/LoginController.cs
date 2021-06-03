using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsernameAndPassword.Models;
using UsernameAndPassword.Services;

namespace UsernameAndPassword.Controllers
{
    public class LoginController : Controller
    {
        private IRepo<LoginModel> _repo;

        public LoginController(IRepo<LoginModel> repo)
        {
            _repo = repo;
        }
        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: LoginController/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(LoginModel user)
        {
            try
            {
                _repo.Register(user);
                TempData["Un"] = user.UserName;
                return RedirectToAction("Login");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Login
        public ActionResult Login()
        {
            if (TempData.Count == 0)
                return View();
            LoginModel user = new LoginModel();
            user.UserName = TempData.Peek("un").ToString();
            return View(user);
        }

        // POST: LoginController/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel user)
        {
            try
            {
                if(_repo.Login(user))
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            return View();
        }
        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


    }
}

