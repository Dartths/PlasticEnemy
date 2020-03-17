using System.Threading.Tasks;
using PlasticEnemy.Data.Entities;

namespace PlasticEnemy.Features.Users
{
    public interface IUsersManager
    {
        Task<User> CreateUser(User user);
    }
}