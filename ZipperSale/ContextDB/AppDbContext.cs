using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using zippersale.Models;

namespace zippersale.ContextDB
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserRegister> UserRegister { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }
        public DbSet<Contact> Contact { get; set; }

        public DbSet<ShopItem> ShopItem { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}