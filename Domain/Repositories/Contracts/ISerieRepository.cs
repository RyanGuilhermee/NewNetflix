using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.Contracts
{
    internal interface ISerieRepository
    {
        int Add(Serie serie);

        Serie GetById(int id);

        IEnumerable<Serie> GetAll();

        void Update(Serie serie);

        bool Delete(int id);
    }
}
