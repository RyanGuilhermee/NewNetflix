using Domain.Models;

namespace Domain.Repositories.Contracts
{
    internal interface IFavoriteRepository
    {
        void Add(Favorite favorite);

        Favorite GetById(int id);

        IEnumerable<Favorite> GetAll();

        void Delete(int id);
    }
}
