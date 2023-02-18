using ClinicManagement.Contracts;
using ClinicManagement.Data;
using ClinicManagement.Models;

namespace ClinicManagement.Repository
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(ClinicManagementDbContext context) : base(context)
        {
        }
    }
}
