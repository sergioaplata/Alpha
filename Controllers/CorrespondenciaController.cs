using Alpha.Contexts;
using Alpha.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Alpha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorrespondenciaController : ControllerBase
    {
        private readonly AppDbContext context;
        public CorrespondenciaController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<CorrespondenciaController>
        [HttpGet]
        public IEnumerable<Correspondencia> Get()
        {
            return context.Correspondencias.ToList();
        }

        // GET api/<CorrespondenciaController>/5
        [HttpGet("{id}")]
        public Correspondencia Get(string id)
        {
            var correspondencia = context.Correspondencias.FirstOrDefault(x => x.Id == id);
            return correspondencia;
        }

        // POST api/<CorrespondenciaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CorrespondenciaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CorrespondenciaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
