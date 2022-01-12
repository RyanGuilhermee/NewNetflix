using Domain.Models;
using Domain.Repositories.Contracts;

namespace Domain.Repositories
{
    public class UserRepository : IUserRepository
    {
        MoviesContext context;
        public UserRepository()
        {
            context = new MoviesContext();
        }

        public void Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            User user = GetById(id);

            context.Users.Remove(user);
            context.SaveChanges();
        }

        public User GetById(int id) => context.Users.Find(id);

        public void Update(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
        }

        public IEnumerable<User> GetAll() => context.Users.ToList();
    }
}
