﻿using Supermarket.API.Attributes;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API
{
    [Injected]
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> ListAsync() => 
            await userRepository.ListAsync();

        public async Task<User> ShowAsync(int id) =>
            await userRepository.FindByIdAsync(id);
    }
}
