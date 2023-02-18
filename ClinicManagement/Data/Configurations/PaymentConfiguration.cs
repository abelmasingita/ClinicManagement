using ClinicManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagement.Data.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
             builder.HasData(
             new Payment
             {
                 Id = "payment1",
                 AppointmentId = "app1",
                 amount = 300.90,
                 method = "method",
                 status = "paid",
                 paymentDate = "20010608"
             }, new Payment
             {
                 Id = "payment2",
                 AppointmentId = "app2",
                 amount = 400.90,
                 method = "method",
                 status = "paid",
                 paymentDate = "20010608"
             }, new Payment
             {
                 Id = "payment3",
                 AppointmentId = "app3",
                 amount = 400.90,
                 method = "method",
                 status = "paid",
                 paymentDate = "20010608"
             });
        }
    }
}
