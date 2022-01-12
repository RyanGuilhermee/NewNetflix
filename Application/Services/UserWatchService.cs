using Domain.Models;
using Domain.Repositories;

namespace Application.Services
{
    public class UserWatchService
    {
        UserWatchRepository userWatchRepository;

        public UserWatchService()
        {
            userWatchRepository = new UserWatchRepository();
        }

        public void AddUserWatch(UserWatch userWatch)
        {
            try
            {
                #region adicionar user

                userWatchRepository.Add(userWatch);

                #endregion
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        } 
        
        public void DeleteUserWatch(int id)
        {
            try
            {
                userWatchRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }
    }
}
