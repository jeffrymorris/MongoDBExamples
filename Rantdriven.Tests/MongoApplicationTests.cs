using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Moq;
using NUnit.Framework;
using Rantdriven.Core;
using Rantdriven.Persistence;

namespace Rantdriven.Tests
{
    [TestFixture]
    public class MongoApplicationTests
    {
        private static volatile string connectionString = "mongodb://localhost";
        private static volatile string databaseName = "testdb";
        private static volatile string collectioName = "testcol";

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void TestInit()
        {
            var app = new Mock<IMongoApplication>();
            app.Setup(x => x.Mongod).Returns(MongoServer.Create(connectionString));

            var server = app.Object.Mongod;
            Assert.IsNotNull(server);

            app.Setup(x => x.GetDatabase(databaseName)).Returns(server.GetDatabase(databaseName));
           
            var database = app.Object.GetDatabase(databaseName);
            Assert.IsNotNull(database);

            var result = database.GetCollection<Post>("posts");
            result.Insert(new Post
                              {
                                  Body = "The body",
                                  Categories = new List<string> {"test", "cat2"},
                                  DatePublished = DateTime.Now,
                                  Title = "Foo man chu"
                              });
            Assert.IsNotNull(result);
        }

        [TearDown]
        public void TearDown()
        {
            
        }
    }
}
