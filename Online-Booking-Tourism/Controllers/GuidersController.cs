using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Booking_Tourism.Models;

namespace Online_Booking_Tourism.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuidersController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public GuidersController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Guiders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Guider>>> GetGuiders()
        {
            return await _context.Guiders.ToListAsync();
        }

        // GET: api/Guiders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Guider>> GetGuider(int id)
        {
            var guider = await _context.Guiders.FindAsync(id);

            if (guider == null)
            {
                return NotFound();
            }

            return guider;
        }

        // PUT: api/Guiders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGuider(int id, Guider guider)
        {
            if (id != guider.Id)
            {
                return BadRequest();
            }

            _context.Entry(guider).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuiderExists(id))
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

        // POST: api/Guiders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Guider>> PostGuider(Guider guider)
        {
            _context.Guiders.Add(guider);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGuider", new { id = guider.Id }, guider);
        }

        // DELETE: api/Guiders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Guider>> DeleteGuider(int id)
        {
            var guider = await _context.Guiders.FindAsync(id);
            if (guider == null)
            {
                return NotFound();
            }

            _context.Guiders.Remove(guider);
            await _context.SaveChangesAsync();

            return guider;
        }

        private bool GuiderExists(int id)
        {
            return _context.Guiders.Any(e => e.Id == id);
        }
    }
}
