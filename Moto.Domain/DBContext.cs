using Microsoft.EntityFrameworkCore;
using Moto.Domain.Models;
using System.Security.Principal;

namespace Moto.Domain
{
    public class DBContext : DbContext
    {
        public DBContext() { }
        public DBContext(DbContextOptions<DBContext> options) : base(options) 
        { 
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }


    }
}
