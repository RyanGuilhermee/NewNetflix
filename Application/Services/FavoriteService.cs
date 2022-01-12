using Domain.Models;
using Domain.Repositories;

namespace Application.Services
{
    public class FavoriteService
    {
        FavoriteRepository favoriteRository;

        public FavoriteService()
        {
            favoriteRository = new FavoriteRepository();
        }

        public void AddFavorite(Favorite favorite)
        {
            try
            {
                #region adicionar movie

                favoriteRository.Add(favorite);

                #endregion
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public Favorite GetFavorite(int id)
        {
            try
            {
                Favorite favorite = favoriteRository.GetById(id);

                return favorite;
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public void DeleteFavorite(int id)
        {
            try
            {
                favoriteRository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public IEnumerable<Favorite> GetAllFavorites() => favoriteRository.GetAll();
    }
}
