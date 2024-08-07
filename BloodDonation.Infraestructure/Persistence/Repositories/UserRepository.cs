﻿using BloodDonation.Core.Entities;
using BloodDonation.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Infraestructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BloodDonationDbContext _dbContext;
        public UserRepository(BloodDonationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(User user)
        {
            await _dbContext.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public Task<List<User>> GetAllAsync()
            => _dbContext.Users.ToListAsync();

        public async Task<User?> GetByEmailandPasswordAsync(string email, string passwordHash)
         => await _dbContext.Users.SingleOrDefaultAsync(u => u.Email == email);

        public Task<User?> GetByIdAsync(int id)
            => _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);

        public async Task UpdateAsync(User user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
