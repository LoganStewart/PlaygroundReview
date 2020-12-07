using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlaygroundReview.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlaygroundReview.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaygroundsController : ControllerBase
    {
        // GET: api/<PlaygroundsController>
        [HttpGet]
        public IEnumerable<Playground> Get()
        {
            return new Playground[] {
                new Playground { Id = Guid.NewGuid().ToString(), Name = "First Park", Description="This is an park description 1." },
                new Playground { Id = Guid.NewGuid().ToString(), Name = "Second Park", Description="This is an park description." },
            };
        }

        // GET api/<PlaygroundsController>/5
        [HttpGet("{id}")]
        public Playground Get(int id)
        {
            return new Playground() { Name = $"Playground ${id}" };
        }

        // POST api/<PlaygroundsController>
        [HttpPost]
        public void Post([FromBody] Playground value)
        {
        }

        // PUT api/<PlaygroundsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Playground value)
        {
        }

        // DELETE api/<PlaygroundsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
