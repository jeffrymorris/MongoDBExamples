using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Rantdriven.Core
{
    public class MongoApplication : IMongoApplication
    {
        public MongoApplication(MongoServerSettings settings)
        {
            ServerSettings = settings;
        }

        public MongoServer Mongod { get; set; }
        
        public MongoServerSettings ServerSettings { get; set; }

        public MongoDatabase GetDatabase(string databaseName)
        {
            return Mongod[databaseName];
        }

        public void Init()
        {
            Mongod = MongoServer.Create(ServerSettings);
        }
    }
}
