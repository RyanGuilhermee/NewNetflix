using Domain.Models;
using Domain.Repositories;

namespace Application.Services
{
    public class SerieService
    {
        SerieRepository serieRository;

        public SerieService()
        {
            serieRository = new SerieRepository();
        }

        public int AddUpdateSerie(Serie serie)
        {
            try
            {
                #region regra de negocio

                bool addFlag = serie.SeId == 0;

                #endregion

                #region adicionar movie

                if (addFlag)
                {

                    int id = serieRository.Add(serie);

                    return id;
                }
                else
                {

                    serieRository.Update(serie);

                    return 0;
                }

                #endregion
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public Serie GetSerie(int id)
        {
            try
            {
                Serie serie = serieRository.GetById(id);

                return serie;
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
                return serieRository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Erro: {ex.Message}");
            }
        }

        public IEnumerable<Serie> GetAllSeries() => serieRository.GetAll();
    }
}

