using WebApiTarjetaCredito.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTarjetaCredito
{
    public class TarjetaCreditoDbContext : DbContext
    {
        public TarjetaCreditoDbContext()
        {

        }

        public TarjetaCreditoDbContext(DbContextOptions<TarjetaCreditoDbContext> options) : base(options)
        {

        }

        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
    }
}