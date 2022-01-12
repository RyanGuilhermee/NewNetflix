using Domain.Models;

namespace Domain.Repositories.Contracts
{
    internal interface IMovieRepository
    {
        int Add(Movie movie);

        Movie GetById(int id);

        IEnumerable<Movie> GetAll();

        void Update(Movie movie);

        bool Delete(int id);
    }
}
