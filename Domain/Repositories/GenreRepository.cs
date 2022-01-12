using Domain.Models;
using Domain.Repositories.Contracts;

namespace Domain.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        MoviesContext context;

        public GenreRepository()
        {
            context = new MoviesContext();
        }

        public void Add(Genre genre)
        {
            context.Genres.Add(genre);
            context.SaveChanges();
        }

        public Genre GetById(int id) => context.Genres.Find(id);

        public void Delete(int id)
        {
            Genre genre = GetById(id);

            context.Genres.Remove(genre);
            context.SaveChanges();
        }

        public IEnumerable<Genre> GetAll() => context.Genres.ToList();
    }
}
