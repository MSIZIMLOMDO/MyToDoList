using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.Data
{
    public interface IDatabaseService<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get();
        TEntity Get(object id);
        bool Insert(TEntity entity, string currentUserID);
        bool Update(TEntity entity, string currentUserID);
        bool Delete(TEntity entity);
        void Delete(List<TEntity> entities);
        IQueryable<TEntity> Find(Func<TEntity, bool> predicate);

    }
}
