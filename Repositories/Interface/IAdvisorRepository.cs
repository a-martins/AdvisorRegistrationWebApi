using AdvisorRegistrationWebApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvisorRegistrationWebApi.Repositories.Interface
{
    public interface IAdvisorRepository : IDisposable
    {
        Task<IEnumerable<Advisor>> GetAdvisorsAsync();
        Task<Advisor> GetAdvisorByIDAsync(int advisorId);
        void InsertAdvisor(Advisor advisor);
        void DeleteAdvisor(int advisorId);
        void UpdateAdvisor(Advisor advisor);
        bool Any(int advisorId);
        Task SaveAsync();
    }
}
