using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jeffBlog.Models;
using jeffBlog.Services;


namespace jeffBlog.Controllers
{
    public class LoginController : Controller
    {
        private readonly MyBlogContext _context;

        public LoginController(MyBlogContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            string UserName = Request.Form["username"];
            string Password = Request.Form["password"];
            var User = _context.User.SingleOrDefault(b => b.UserName == UserName && b.Password == Password);
            if (User != null && User.IsValid == true)
                return RedirectToAction("Index", "Home");
            else
                return RedirectToAction("Index", "Login");
        }

        
    }
}