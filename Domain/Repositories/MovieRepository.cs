using Domain.Models;
using Domain.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        MoviesContext context;

        public MovieRepository()
        {
            context = new MoviesContext();
        }

        public int Add(Movie movie)
        {    
            context.Movies.Add(movie);
            context.SaveChanges();

            return movie.MvId;
        }

        public bool Delete(int id)
        {
           Movie movie = GetById(id);

            if (movie.MvId > 0)
            {
                context.Movies.Remove(movie);
                context.SaveChanges();

                return true;
            }

            return false;
        }

        public Movie GetById(int id)
        {
            return context.Movies.Include(obj => obj.Gr).FirstOrDefault(x => x.MvId == id);
        }

        public void Update(Movie movie)
        {
            context.Movies.Update(movie);
            context.SaveChanges();
        }

        public IEnumerable<Movie> GetAll() => context.Movies.Include(obj => obj.Gr).ToList();
    }
}
