using System;
using System.Collections.Generic;
using System.Text;
using FlyArcARS.ApplicationLogic.Data;
using Microsoft.EntityFrameworkCore;

namespace FlyArcARS.EFDataAccess
{
    public class FlyArcDbContext: DbContext
    {
        public FlyArcDbContext(DbContextOptions<FlyArcDbContext> options) : base(options)
        {
        }

        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Passenger> Passenger { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Customer> Customer { get; set; }

    }
}
