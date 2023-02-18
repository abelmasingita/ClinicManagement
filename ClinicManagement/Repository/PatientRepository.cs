using ClinicManagement.Contracts;
using ClinicManagement.Data;
using ClinicManagement.Models;

namespace ClinicManagement.Repository
{
    public class PatientRepository : GenericRepository<Patient> , IPatientRepository
    {
        public PatientRepository(ClinicManagementDbContext context) : base(context)
        {
        }
    }
}
