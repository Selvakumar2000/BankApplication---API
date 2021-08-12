using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    //inherit entity framework class
    public class PaymentDetailsContext : DbContext
    {
        //database provider and connection string
        public PaymentDetailsContext(DbContextOptions<PaymentDetailsContext> options) : base(options)
        {

        }
        public DbSet<PaymentDetails> /*table name*/PaymentDetail { get; set; }

    }
}
