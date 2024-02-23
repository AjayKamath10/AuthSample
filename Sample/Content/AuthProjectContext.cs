using Microsoft.EntityFrameworkCore;
using Sample.Models;
using System.Data.Common;

namespace Sample.Content
{
    public class AuthProjectContext : DbContext
    {
        public AuthProjectContext(DbContextOptions<AuthProjectContext> options) : base(options)
        {
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Person> Persons { get; set; }
        
    } }
    
