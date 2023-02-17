using ClinicManagement.Contracts;
using ClinicManagement.Data;
using ClinicManagement.Models;

namespace ClinicManagement.Repository
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        private readonly ClinicManagementDbContext context;

        public DoctorRepository(ClinicManagementDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
