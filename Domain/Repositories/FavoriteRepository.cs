using Domain.Models;
using Domain.Repositories.Contracts;

namespace Domain.Repositories
{
    public class FavoriteRepository : IFavoriteRepository
    {
        MoviesContext context;

        public FavoriteRepository()
        {
            context = new MoviesContext();
        }

        public void Add(Favorite favorite)
        {
            context.Favorites.Add(favorite);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Favorite favorite = GetById(id);

            context.Favorites.Remove(favorite);
            context.SaveChanges();
        }

        public Favorite GetById(int id) => context.Favorites.Find(id);

        public IEnumerable<Favorite> GetAll() => context.Favorites.ToList();
    }
}
