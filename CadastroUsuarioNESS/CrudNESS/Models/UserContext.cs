using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNESS.Models
{
    public class UserContext : DbContext 
    {
        public UserContext(DbContextOptions<UserContext> options ) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
