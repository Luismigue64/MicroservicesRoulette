using MongoDB.Driver;
using roulette.api.services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roulette.api.services.Core.MongoDbContext
{
    interface IRouletteContext
    {
        IMongoCollection<Roulette> Roulettes { get; }
    }
}
