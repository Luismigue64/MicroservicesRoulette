using MongoDB.Driver;
using roulette.api.services.Core.Entities;
using roulette.api.services.Core.MongoDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roulette.api.services.Repository
{
    public class RouletteRepository : IRouletteRepository
    {
        private readonly IRouletteContext rouletteContext;
        public RouletteRepository(IRouletteContext rouletteContext) 
        {
            this.rouletteContext = rouletteContext;
        }
        public async Task<IEnumerable<Roulette>> GetAllRoulettes()
        {
            return await this.rouletteContext.Roulettes.Find(p => true).ToListAsync();
        }
        public async Task<Roulette> GetRouletteById(string id)
        {
            return await this.rouletteContext.Roulettes.Find(roulette => roulette.IdRoulette == id).SingleOrDefaultAsync();
        }
        public async Task InsertRoulette(Roulette roulette)
        {
            await this.rouletteContext.Roulettes.InsertOneAsync(roulette);
        }
        public async Task UpdateRouletteById(string id, string status)
        {
            var filter = Builders<Roulette>.Filter.Eq(s => s.IdRoulette, id);
            var update = Builders<Roulette>.Update.Set(s => s.Status, status);
            await this.rouletteContext.Roulettes.UpdateOneAsync(filter, update);
        }
    }
}
