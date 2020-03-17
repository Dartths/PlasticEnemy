using Microsoft.EntityFrameworkCore;
using PlasticEnemy.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlasticEnemy.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _peContext;

        public UserRepository(DbContext pEContext)
        {
            _peContext = pEContext ?? throw new ArgumentNullException(nameof(pEContext));
        }


        public async Task<User> CreateUser(User user)
        {
            await _peContext.AddAsync(user);
            await _peContext.SaveChangesAsync();

            return user;
        }

        public async Task<User> GetUser(Guid userId)
        {
            return await _peContext.FindAsync<User>(userId);
        }
    }
}