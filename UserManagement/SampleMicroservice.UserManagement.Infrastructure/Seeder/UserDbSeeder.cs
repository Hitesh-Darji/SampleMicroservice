using Microsoft.EntityFrameworkCore;
using SampleMicroservice.UserManagement.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.UserManagement.Infrastructure.Seeder
{
    public class UserDbSeeder
    {
        private readonly UserDbContext _ctx;
        public UserDbSeeder(UserDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Seed()
        {
            try
            {
               await _ctx.Database.MigrateAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
