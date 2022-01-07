using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAffection_Tutorial_Demo.Models
{
    public class PaymentDetailsDbContext : DbContext
    {
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        public PaymentDetailsDbContext(DbContextOptions<PaymentDetailsDbContext> options):base(options)
        {

        }
    }
}
