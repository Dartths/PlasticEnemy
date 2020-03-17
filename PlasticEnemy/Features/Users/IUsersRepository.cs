using System;
using System.Threading.Tasks;
using PlasticEnemy.Data.Entities;

namespace PlasticEnemy.Features.Users
{
    public interface IUsersRepository
    {
        Task<User> CreateUser(User user);
        Task<User> GetUser(Guid userId);
    }
}