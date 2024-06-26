using BloodDonation.Core.Entities;
using BloodDonation.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Tests.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        public Task AddAsync(Address address)
        {
            throw new NotImplementedException();
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
