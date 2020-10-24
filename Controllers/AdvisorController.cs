using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AdvisorRegistrationWebApi.Models;
using AdvisorRegistrationWebApi.Models.Contexts;

namespace AdvisorRegistrationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvisorController : ControllerBase
    {
        private readonly AdvisorDbContext _context;

        public AdvisorController(AdvisorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Advisor>>> GetAdvisors()
        {
            return await _context.Advisors.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Advisor>> GetAdvisor(int id)
        {
            var advisor = await _context.Advisors.FindAsync(id);

            if (advisor == null) return NotFound();

            return advisor;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdvisor(int id, Advisor advisor)
        {
            if (id != advisor.id) return BadRequest();

            _context.Entry(advisor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdvisorExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Advisor>> PostAdvisor(Advisor advisor)
        {
            _context.Advisors.Add(advisor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdvisor", new { id = advisor.id }, advisor);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Advisor>> DeleteAdvisor(int id)
        {
            var advisor = await _context.Advisors.FindAsync(id);
            if (advisor == null)
            {
                return NotFound();
            }

            _context.Advisors.Remove(advisor);
            await _context.SaveChangesAsync();

            return advisor;
        }

        private bool AdvisorExists(int id)
        {
            return _context.Advisors.Any(e => e.id == id);
        }
    }
}
