using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hughmail.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hughmail.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Email> Emails { get; set; }

        public DbSet<AppUser> Users { get; set; }

        public DbSet<Label> Labels { get; set; }

        public DbSet<Receipient> Receipients { get; set; }
    }
}