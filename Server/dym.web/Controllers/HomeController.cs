using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dym.web.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
          var list= Context.Context.Conn.Query<User>("select* from sys_member;");
            return View();
        }
    }
    class User
    {
        public long id { get; set; }
        public string name { get; set; }
    }
}
