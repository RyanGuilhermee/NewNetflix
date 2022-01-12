using Domain.Models;
using Domain.Repositories.Contracts;

namespace Domain.Repositories
{
    public class WatchLaterRepository : IWatchLaterRepository
    {
        MoviesContext context;

        public WatchLaterRepository()
        {
            context = new MoviesContext();
        }

        public void Add(WatchLater watchLater)
        {
            context.Add(watchLater);
            context.SaveChanges();  
        }

        public void Delete(int id)
        {
            WatchLater watchLater = GetById(id);
            context.Remove(watchLater);
            context.SaveChanges();
        }

        public WatchLater GetById(int id) => context.WatchLaters.Find(id);
    }
}
