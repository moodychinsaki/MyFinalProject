using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    /*generic constraint T : sadece referans tip olabilir şekle getirdik(class ve IEntity implemente
    eden bir nesne olabilir*/
    public interface IEntityRepository<T> where T: class, IEntity , new()
    {
        List<T> GetAll( Expression<Func<T,bool>> filter= null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);

        void Delete(T entity);
        /*
        List<T> GetByCategory(int categoryid); bu koda artık ihtiyaç yok çünkü expression ile genel tanımladık

        */

    }
}
