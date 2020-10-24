using AdvisorRegistrationWebApi.Repositories.Interface;
using AdvisorRegistrationWebApi.Services.Interfaces;
using System;

namespace AdvisorRegistrationWebApi.Services
{
    public class AdvisorDbService : IAdvisorDbService
    {
        public IAdvisorRepository AdvisorRepository { get; }

        public AdvisorDbService(IAdvisorRepository advisorRepository)
        {
            AdvisorRepository = advisorRepository ?? throw new ArgumentNullException(nameof(advisorRepository));
        }

        public bool AdvisorExists(int id)
        {
            return AdvisorRepository.Any(id);
        }
    }
}
