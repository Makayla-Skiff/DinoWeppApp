using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DinoWebApp1._0.Data;

namespace DinoWebApp1._0.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DinoWebApp1._0.Data.Dinos> Dinos { get; set; }
        public DbSet<DinoWebApp1._0.Data.Exhibits> Exhibits { get; set; }
    }
}
