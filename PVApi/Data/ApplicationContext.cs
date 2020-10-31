using Microsoft.EntityFrameworkCore;
using PVApi.Data.Context;
using PVApi.Models;

namespace PVApi.Data
{
    public class ApplicationContext : DbContext, IContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
