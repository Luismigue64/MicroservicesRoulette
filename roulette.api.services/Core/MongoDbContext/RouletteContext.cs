using Microsoft.Extensions.Options;
using MongoDB.Driver;
using roulette.api.services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roulette.api.services.Core.MongoDbContext
{
    public class RouletteContext : IRouletteContext
    {
        private readonly IMongoDatabase db;
        public RouletteContext(IOptions<MongoDbSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            db = client.GetDatabase(options.Value.Database);
        }
        public IMongoCollection<Roulette> Roulettes => db.GetCollection<Roulette>("Roulette");
    }
}
