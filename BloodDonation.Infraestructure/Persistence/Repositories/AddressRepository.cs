using BloodDonation.Core.Entities;
using BloodDonation.Core.Repositories;

namespace BloodDonation.Infraestructure.Persistence.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly BloodDonationDbContext _dbContext;

        public AddressRepository(BloodDonationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Address address)
        {
            await _dbContext.AddAsync(address);
        }

        public Task<List<Address>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Address?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Address?> GetMainByUser(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
