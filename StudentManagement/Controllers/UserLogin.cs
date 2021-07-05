using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagement.Models;


namespace StudentManagement.Controllers
{
    public class UserLogin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserEntity user)
        {
            ViewData["ErrorMsg"] =  Validate(user);
            if (string.IsNullOrEmpty(ViewData["ErrorMsg"].ToString()))
                return RedirectToAction("Index", "StudentMangementController");
            else
                return View();
        }

        private string Validate(UserEntity user)
        {
            string message = "";
            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
                 message = "Credential Can Not Empty";
            //else if (user.Username == "admin" && user.Password == "admin")
            //     message = "Login Successfull!";
            else if(user.Username != "admin")
                 message = "Invalid Email!";
            else if (user.Password != "admin")
                message = "Invalid Password!";
            
            return message;
        }
    }
}
