using Alpha.Contexts;
using Alpha.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<ActionResult<IEnumerable<Correspondencia>>> GetCorrespondencias()
        {
            return await context.Correspondencias.ToListAsync();
        }

        // GET api/<CorrespondenciaController>/5
        [HttpGet("{id}")]
        public async Task<Correspondencia> GetCorrespondenciaById(string id)
        {
            return await context.Correspondencias.FindAsync(id);
        }

        // POST api/<CorrespondenciaController>
        [HttpPost]
        public async Task<ActionResult<Correspondencia>> PostCorrespondencia(Correspondencia item)
        {
            context.Correspondencias.Add(item);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCorrespondencias), new { id = item.Id }, item);
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
