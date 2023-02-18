using ClinicManagement.Contracts;
using ClinicManagement.Data;
using ClinicManagement.Models;

namespace ClinicManagement.Repository
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ClinicManagementDbContext context) : base(context)
        {
        }
    }
}
