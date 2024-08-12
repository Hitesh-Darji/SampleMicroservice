using Microsoft.EntityFrameworkCore;
using SampleMicroservice.UserManagement.Domain.Entities;

namespace SampleMicroservice.UserManagement.Infrastructure.Contexts
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
