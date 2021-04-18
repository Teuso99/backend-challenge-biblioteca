using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BibliotecaAPI.Models;

namespace BibliotecaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ObrasController : ControllerBase
    {
        private readonly ObraContext _context;

        public ObrasController(ObraContext context)
        {
            _context = context;
        }

        // GET: Obras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Obra>>> GetObra()
        {
            return await _context.Obra.ToListAsync();
        }

        // GET: Obras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Obra>> GetObra(long id)
        {
            var obra = await _context.Obra.FindAsync(id);

            if (obra == null)
            {
                return NotFound();
            }

            return obra;
        }

        // PUT: Obras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObra(long id, Obra obra)
        {
            if (id != obra.Id)
            {
                return BadRequest();
            }

            _context.Entry(obra).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObraExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: Obras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Obra>> PostObra(Obra obra)
        {
            _context.Obra.Add(obra);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObra", new { id = obra.Id }, obra);
        }

        // DELETE: Obras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObra(long id)
        {
            var obra = await _context.Obra.FindAsync(id);
            if (obra == null)
            {
                return NotFound();
            }

            _context.Obra.Remove(obra);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ObraExists(long id)
        {
            return _context.Obra.Any(e => e.Id == id);
        }
    }
}
