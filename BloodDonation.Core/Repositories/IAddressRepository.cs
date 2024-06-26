using BloodDonation.Core.Entities;

namespace BloodDonation.Core.Repositories
{
    public interface IAddressRepository
    {
        Task<List<Address>> GetAllAsync();
        Task<Address?> GetByIdAsync(int id);
        Task<Address?> GetMainByUser(int UserId);
        Task AddAsync(Address address);
        Task UpdateAsync(Address address);
    }
}
