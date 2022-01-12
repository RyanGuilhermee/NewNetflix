using Domain.Models;

namespace Domain.Repositories.Contracts
{
    internal interface IUserRepository
    {
        void Add(User user);

        void Update(User user);

        User GetById(int id);

        IEnumerable<User> GetAll();

        void Delete(int id);
    }
}
