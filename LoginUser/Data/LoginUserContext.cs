using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoginUser.Models.Entities;

namespace LoginUser.Data
{
    public class LoginUserContext : DbContext
    {
        public LoginUserContext (DbContextOptions<LoginUserContext> options)
            : base(options)
        {
        }

        public DbSet<Roles> Roles { get; set; } = default!;
        public DbSet<Usuarios> Usuarios { get; set; } = default!;
    }
}
