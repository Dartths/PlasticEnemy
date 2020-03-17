using System;
using System.Threading.Tasks;
using PlasticEnemy.Data.Entities;

namespace PlasticEnemy.Data.Repositories
{
    public interface IUserRepository
    {
        Task<User> CreateUser(User user);
        Task<User> GetUser(Guid userId);
    }
}