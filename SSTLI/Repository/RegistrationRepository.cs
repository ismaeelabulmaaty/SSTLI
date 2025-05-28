using Microsoft.EntityFrameworkCore;
using SSTLI.Data;
using SSTLI.Interface;
using SSTLI.Models;

namespace SSTLI.Repository
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly SstliDbContext _context;

        public RegistrationRepository(SstliDbContext context)
        {
            _context = context;
        }
        public async Task<RegistrationAttendanceOrOnline> AddAsync(RegistrationAttendanceOrOnline registration)
        {
            _context.RegistrationsAttendanceOrOnline.Add(registration);
            await _context.SaveChangesAsync();
            return registration;
        }

        public async Task<int> SaveChangesAsync()
        {

            return await _context.SaveChangesAsync();

        }
    }
}
