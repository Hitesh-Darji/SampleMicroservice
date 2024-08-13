using SampleMicroservice.UserManagement.Domain.Entities;

namespace SampleMicroservice.UserManagement.Abstraction.Infrastructure
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User?> GetByIdAsync(int id);
    }
}
