﻿using Common.Contracts.Repository.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.User
{
    public class UserRepository: IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {

            _dbContext = dbContext;

        }
        public async Task AddUserAsync() { }
        public async Task UpdateUserAsync() { }
        public async Task GetUserAsync() { }
        public async Task GetUserByIdAsync() { }
        public async Task DeleteUserAsync() { }
    }
}
