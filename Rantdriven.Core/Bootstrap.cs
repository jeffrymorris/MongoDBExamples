using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Rantdriven.Core
{
    public class Bootstrap
    {
        public static void Main(IMongoApplication application)
        {
            var connectionString = ConfigurationManager.AppSettings["MongoDb"];
            application.Mongod = MongoServer.Create(connectionString);
        }
    }
}
