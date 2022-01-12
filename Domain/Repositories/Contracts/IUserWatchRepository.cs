using Domain.Models;

namespace Domain.Repositories.Contracts
{
    internal interface IUserWatchRepository
    {
        void Add(UserWatch userWatch);

        UserWatch GetById(int id);  

        void Delete(int id);
    }
}
