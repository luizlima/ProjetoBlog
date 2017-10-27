using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlog.MongoDBAccess.Interfaces
{
    public interface IRepository<TEntity>: IDisposable
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(string id);
        void Add(TEntity entity);
        long Remove(string id);
        ReplaceOneResult Update(string id, TEntity entityToUpdate);
    }
}
