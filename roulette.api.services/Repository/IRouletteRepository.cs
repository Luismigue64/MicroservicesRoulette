using roulette.api.services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roulette.api.services.Repository
{
    public interface IRouletteRepository
    {
        Task<IEnumerable<Roulette>> GetAllRoulettes();
        Task<Roulette> GetRouletteById(string id);
        Task UpdateRouletteById(string id, string status);
        Task InsertRoulette(Roulette roulette);
    }
}
