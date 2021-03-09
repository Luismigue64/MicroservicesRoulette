using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roulette.api.services.Core
{
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
