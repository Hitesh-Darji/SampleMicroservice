using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SampleMicroservice.UserManagement.Abstraction.Infrastructure;
using SampleMicroservice.UserManagement.Domain.Entities;
using SampleMicroservice.UserManagement.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMicroservice.UserManagement.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _userDbContext;
        private readonly ILogger<UserRepository> _logger;
        public UserRepository(UserDbContext userDbContext, ILogger<UserRepository> logger)
        {
            _userDbContext = userDbContext ?? throw new ArgumentNullException(nameof(userDbContext)); 
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<List<User>> GetAllAsync()
        {
            return await _userDbContext.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _userDbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
