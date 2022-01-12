using Domain.Models;

namespace Domain.Repositories.Contracts
{
    internal interface IWatchLaterRepository
    {
        void Add(WatchLater watchLater);

        WatchLater GetById(int id);

        void Delete(int id);
    }
}
