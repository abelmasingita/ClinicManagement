using ClinicManagement.Contracts;
using ClinicManagement.Data;
using ClinicManagement.Models;

namespace ClinicManagement.Repository
{
    public class PrescriptionRepository : GenericRepository<Prescription>, IPrescriptionRepository
    {
        public PrescriptionRepository(ClinicManagementDbContext context) : base(context)
        {
        }
    }
}
