using Domain.Models;
using Domain.Repositories.Contracts;

namespace Domain.Repositories
{
    public class SerieRepository : ISerieRepository
    {
        MoviesContext context;

        public SerieRepository()
        {
            context = new MoviesContext();
        }

        public int Add(Serie serie)
        {
            context.Series.Add(serie);
            context.SaveChanges();

            return serie.SeId;
        }

        public bool Delete(int id)
        {
            Serie serie = GetById(id);

            if (serie.SeId > 0)
            {
                context.Series.Remove(serie);
                context.SaveChanges();

                return true;
            }

            return false;
        }

        public Serie GetById(int id) => context.Series.Find(id);

        public void Update(Serie serie)
        {
            context.Series.Update(serie);
            context.SaveChanges();
        }

        public IEnumerable<Serie> GetAll() => context.Series.ToList();
    }
}
