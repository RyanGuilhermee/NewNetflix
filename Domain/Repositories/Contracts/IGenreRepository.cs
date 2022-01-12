using Domain.Models;

namespace Domain.Repositories.Contracts
{
    internal interface IGenreRepository
    {
        void Add(Genre genre);

        Genre GetById(int id);

        IEnumerable<Genre> GetAll();

        void Delete(int id);
    }
}
