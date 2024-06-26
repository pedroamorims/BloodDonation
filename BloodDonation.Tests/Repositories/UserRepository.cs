using BloodDonation.Core.Repositories;

namespace BloodDonation.Tests.Repositories
{
    public class UserTestRepository : IUserRepository
    {
        public Task AddAsync(Core.Entities.User user)
        {
            return Task.CompletedTask;
        }

        public Task<List<Core.Entities.User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Core.Entities.User?> GetByEmailandPasswordAsync(string email, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Entities.User?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Core.Entities.User user)
        {
            throw new NotImplementedException();
        }
    }
}
