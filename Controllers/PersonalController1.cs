using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gitHubDemo.Controllers
{
    [Route("api/[controller]")]
    public class PersonalController1 : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public Person Get()
        {
            var me = new Person()
            {
                name = "Danny",
                age = 100,
            };
            return me;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class Person
    {
        public String name{ get; set; }
        public int age { get; set; }
    }
}
