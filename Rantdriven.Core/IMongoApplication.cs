using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Rantdriven.Core
{
    public interface IMongoApplication
    {
        MongoServer Mongod { get; }

        MongoDatabase GetDatabase(string databaseName);

        MongoServerSettings ServerSettings { get; }

        void Init();
    }
}
    