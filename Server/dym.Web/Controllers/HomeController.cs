using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            var list = baseRepository.db.Queryable<Model.sys_member>().ToList();
            return View(list);
        }
        public IActionResult CompanyDetail(long id)
        {
            var list = baseRepository.db.Queryable<Model.bif_company>().Where(c=>c.id==id).First();
            return View(list);
        }
    }
}
