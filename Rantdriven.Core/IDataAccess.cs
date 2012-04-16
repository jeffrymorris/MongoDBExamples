using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Rantdriven.Core
{
    public interface IDataAccess<T> where T : IDataTransfer
    {
        MongoDatabase MongoDatabase { get; set; }

        T Find(int id);

        void Save(T t);

        void Delete(T t);

        IList<T> List(int start, int length);

        IList<T> List();
    }
}
