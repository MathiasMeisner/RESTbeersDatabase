using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OblOpgave4REST.Managers;
using Obl_Opgave1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OblOpgave4REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeersController : ControllerBase
    {
        private readonly BeersManager _manager = new BeersManager();

        // GET: api/<BeersController>
        [HttpGet]
        public List<Beer> Get([FromQuery] string name, [FromQuery] int id, [FromQuery] int price, [FromQuery] double abv)
        {
            List<Beer> beers = _manager.GetAll(name, id, price, abv);
            return beers;
        }

        // GET api/<BeersController>/5
        [HttpGet("{id}")]
        public Beer Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<BeersController>
        [HttpPost]
        public Beer Post([FromBody] Beer value)
        {
            return _manager.Add(value);
        }

        // PUT api/<BeersController>/5
        [HttpPut("{id}")]
        public Beer Put(int id, string name, int price, double abv, [FromBody] Beer value)
        {
            return _manager.Update(id, name, price, abv, value);
        }

        // DELETE api/<BeersController>/5
        [HttpDelete("{id}")]
        public Beer Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
