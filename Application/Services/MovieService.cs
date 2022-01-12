using Domain.Models;
using Domain.Repositories;

namespace Application.Services
{
    public class MovieService
    {
        MovieRepository movieRository;

        public MovieService()
        {
            movieRository = new MovieRepository();
        }

        public int AddUpdateMovie(Movie movie)
        {
            try
            {
                #region regra de negocio

                bool addFlag = movie.MvId == 0;

                #endregion

                #region adicionar movie

                if (addFlag)
                {
                    
                    int id = movieRository.Add(movie);

                    return id;
                }
                else
                {
                   
                    movieRository.Update(movie);

                    return 0;
                }

                #endregion
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");         
            }
        }

        public Movie GetMovie(int id)
        {
            try
            {
                Movie movie = movieRository.GetById(id);

                return movie;
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}"); 
            }
        }

        public bool Delete(int id)
        {
            try
            {
                return movieRository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public IEnumerable<Movie> GetAllMovies() => movieRository.GetAll();
    }
}
