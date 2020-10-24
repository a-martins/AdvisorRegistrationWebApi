using AdvisorRegistrationWebApi.Models;
using AdvisorRegistrationWebApi.Models.Contexts;
using AdvisorRegistrationWebApi.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvisorRegistrationWebApi.Repositories
{
    public class AdvisorRepository : IAdvisorRepository
    {
        private readonly AdvisorDbContext _context;
        private bool disposed = false;

        public AdvisorRepository(AdvisorDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Advisor>> GetAdvisorsAsync()
        {
            return await _context.Advisors.ToListAsync();
        }

        public async Task<Advisor> GetAdvisorByIDAsync(int advisorId)
        {
            return await _context.Advisors.FindAsync(advisorId);
        }

        public bool Any(int advisorId)
        {
            return _context.Advisors.Any(e => e.id == advisorId);
        }

        public void InsertAdvisor(Advisor advisor)
        {
            _context.Advisors.Add(advisor);
        }

        public void UpdateAdvisor(Advisor advisor)
        {
            _context.Entry(advisor).State = EntityState.Modified;
        }

        public void DeleteAdvisor(int advisorId)
        {
            Advisor advisor = _context.Advisors.Find(advisorId);
            _context.Advisors.Remove(advisor);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

    }
}
