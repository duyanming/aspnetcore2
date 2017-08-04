using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dym.IRepository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dym.Web.Controllers
{
    [Route("Api/[controller]")]
    public class ApiController : Controller
    {
        private readonly IBaseRepository baseRepository;
        public ApiController(IBaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Model.sys_member> Get()
        {
            //return new string[] { "value1", "value2" };
            return baseRepository.db.Queryable<Model.sys_member>().ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
