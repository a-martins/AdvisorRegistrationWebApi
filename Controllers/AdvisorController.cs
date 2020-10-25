using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdvisorRegistrationWebApi.Models;
using AdvisorRegistrationWebApi.Repositories.Interface;
using AdvisorRegistrationWebApi.Services.Interfaces;

namespace AdvisorRegistrationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvisorController : ControllerBase
    {
        public IAdvisorRepository AdvisorRepository { get; }
        public IAdvisorService AdvisorService { get; }

        public AdvisorController(IAdvisorRepository advisorRepository,
            IAdvisorService advisorService)
        {
            AdvisorRepository = advisorRepository ?? throw new System.ArgumentNullException(nameof(advisorRepository));
            AdvisorService = advisorService ?? throw new System.ArgumentNullException(nameof(advisorService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Advisor>>> GetAdvisors()
        {
            var result = await AdvisorRepository.GetAdvisorsAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Advisor>> GetAdvisor(int id)
        {
            var advisor = await AdvisorRepository.GetAdvisorByIDAsync(id);

            if (advisor == null) return NotFound();

            return Ok(advisor);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Advisor>> PutAdvisor(int id, Advisor advisor)
        {
            if (!AdvisorService.AdvisorExists(id)) return NotFound();

            AdvisorRepository.UpdateAdvisor(advisor);
            await AdvisorRepository.SaveAsync();

            return Ok(advisor);
        }

        [HttpPost]
        public async Task<ActionResult<Advisor>> PostAdvisor(Advisor advisor)
        {
            AdvisorRepository.InsertAdvisor(advisor);
            await AdvisorRepository.SaveAsync();

            return CreatedAtAction("GetAdvisor", new { advisor.id }, advisor);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Advisor>> DeleteAdvisor(int id)
        {
            if (!AdvisorService.AdvisorExists(id)) return NotFound();

            AdvisorRepository.DeleteAdvisor(id);
            await AdvisorRepository.SaveAsync();

            return Ok();
        }
    }
}
