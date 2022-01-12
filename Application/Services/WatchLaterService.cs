using Domain.Models;
using Domain.Repositories;

namespace Application.Services
{
    public class WatchLaterService
    {
        WatchLaterRepository watchLaterRepository;

        public WatchLaterService()
        {
            watchLaterRepository = new WatchLaterRepository();
        }

        public void AddWatchLater(WatchLater watchLater)
        {
            try
            {
                #region adicionar user

                watchLaterRepository.Add(watchLater);

                #endregion
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public void DeleteWatchLater(int id)
        {
            try
            {
                watchLaterRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }
    }
}
