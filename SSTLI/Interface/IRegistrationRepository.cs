using SSTLI.Models;

namespace SSTLI.Interface
{
    public interface IRegistrationRepository
    {
        Task<RegistrationAttendanceOrOnline> AddAsync(RegistrationAttendanceOrOnline registration);
        Task<int> SaveChangesAsync();

    }
}
