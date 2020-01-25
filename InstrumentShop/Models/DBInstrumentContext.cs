using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace InstrumentShop.Models
{
    class DBInstrumentContext : DbContext
    {
        public string connectionString = @"Server=localhost\SQLEXPRESS;Database=instruments;Trusted_Connection=True;";
        public DbSet<Instrument> Instruments{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=localhost/SQLEXPRESS;Database=instruments;Trusted_Connection=True;");
                //optionsBuilder.UseSqlServer(@"Server=DESKTOP-NIC196F\SQLEXPRESS;Database=instruments;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=instruments;Trusted_Connection=True;");
                //optionsBuilder.UseSqlServer("Server=DESKTOP-NIC196F/SQLEXPRESS;Database=instruments;Trusted_Connection=True;");
                //DESKTOP-NIC196F........DESKTOP-NIC196F\SQLEXPRESS
                //Data Source = DESKTOP - NIC196F\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False


            }
        }

        public string getConnectionString()
        {
            return connectionString;
        }

    }

}
