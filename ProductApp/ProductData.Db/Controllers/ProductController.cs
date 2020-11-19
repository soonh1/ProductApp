using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductModels.Lib;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductData.Db.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            List<Student> students = new List<Student>();
            // hent liste med studerende fra db
            // vi opretter mock data
            for (int i = 0; i < 20; i++)
            {
                Student student = new Student
                {
                    Id = i,
                    FirstName = "John" + i,
                    LastName = "doe" + i,
                    CPR = 14080012 + i,
                    Email = "john@doe.dk",

                    Address = new Address
                    {
                        Street = "Seeblasgade",
                        No = i.ToString(),
                        Zip = 5000 + i,
                        City = "Odense",
                        Country = "Denmark"
                    }
                };
                students.Add(student);
            }
            return students;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
