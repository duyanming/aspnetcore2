using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using dym.LogicService;
using dym.IRepository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dym.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBaseRepository baseRepository;
        public HomeController(IBaseRepository baseRepository) {
            this.baseRepository = baseRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var list = new PlatformModule().GetList<Model.sys_member>();
            return View(list);
        }
    }
}
