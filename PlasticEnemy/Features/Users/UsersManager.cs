using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlasticEnemy.Data.Entities;

namespace PlasticEnemy.Features.Users
{
    public class UsersManager : IUsersManager
    {
        private readonly IUsersRepository _usersRepository;

        public UsersManager(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository ?? throw new ArgumentNullException(nameof(usersRepository));
        }

        public async Task<User> CreateUser(User user)
        {
            return await _usersRepository.CreateUser(user);
        }
    }
}
