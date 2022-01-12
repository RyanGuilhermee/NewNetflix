using Domain.Models;
using Domain.Repositories.Contracts;

namespace Domain.Repositories
{
    public class UserWatchRepository : IUserWatchRepository
    {
        MoviesContext context;

        public UserWatchRepository()
        {
            context = new MoviesContext();
        }

        public void Add(UserWatch userWatch)
        {
            context.UserWatches.Add(userWatch);
            context.SaveChanges();  
        }

        public UserWatch GetById(int id) => context.UserWatches.Find(id);

        public void Delete(int id)
        {
            UserWatch userWatch = GetById(id);

            context.UserWatches.Remove(userWatch);
            context.SaveChanges();
        }
    }
}
