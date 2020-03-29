using Microsoft.EntityFrameworkCore;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Infrastructure.MsSqlDbService.Service
{
    class MsSqlDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=db-mssql; Initial Catalog=s16682; Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Student { get; set; }
    }
}
