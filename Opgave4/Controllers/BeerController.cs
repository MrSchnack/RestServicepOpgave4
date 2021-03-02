using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Opgave1;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Opgave4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private static BeerManager _manager = new BeerManager();

        // GET: api/<BeerController>
        [HttpGet]
        public IEnumerable<Beer> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<BeerController>/5
        [HttpGet("{id}")]
        public Beer Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<BeerController>
        [HttpPost]
        public Beer Post([FromBody] Beer value)
        {
            return _manager.Add(value);
        }

        // PUT api/<BeerController>/5
        [HttpPut("{id}")]
        public Beer Put(int id, [FromBody] Beer value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<BeerController>/5
        [HttpDelete("{id}")]
        public Beer Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
