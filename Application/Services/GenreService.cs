using Domain.Models;
using Domain.Repositories;

namespace Application.Services
{
    public class GenreService
    {
        GenreRepository genreRository;

        public GenreService()
        {
            genreRository = new GenreRepository();
        }

        public void AddGenre(Genre genre)
        {
            try
            {
                genreRository.Add(genre);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public Genre GetGenre(int id)
        {
            try
            {
                return genreRository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public void DeleteGenre(int id)
        {
            try
            {
                genreRository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public IEnumerable<Genre> GetAllGenres() => genreRository.GetAll();
    }
}
