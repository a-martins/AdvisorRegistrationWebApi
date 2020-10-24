using AdvisorRegistrationWebApi.Repositories.Interface;
using AdvisorRegistrationWebApi.Services.Interfaces;
using System;

namespace AdvisorRegistrationWebApi.Services
{
    public class AdvisorService : IAdvisorService
    {
        public IAdvisorRepository AdvisorRepository { get; }

        public AdvisorService(IAdvisorRepository advisorRepository)
        {
            AdvisorRepository = advisorRepository ?? throw new ArgumentNullException(nameof(advisorRepository));
        }

        public bool AdvisorExists(int id)
        {
            return AdvisorRepository.Any(id);
        }
    }
}
