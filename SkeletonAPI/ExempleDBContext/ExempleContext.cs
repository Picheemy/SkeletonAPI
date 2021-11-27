using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkeletonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace SkeletonAPI.ExempleDBContext
{
    public class ExempleContext : IdentityDbContext<User, Role, Guid>
    {
        public ExempleContext(DbContextOptions<ExempleContext> options) : base(options)
        {

        }

        public DbSet<Exemple> Exemple { get; set; }
    }
}
