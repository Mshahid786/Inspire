using IInspire.Erp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Inspire.Erp.Infrastructure.Database.Repositoy
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IQueryable<T> GetAsQueryable();
        //T Get(long id);
        void Insert(T entity);


        IQueryable<T> GetWithInclude(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        void InsertList(List<T> entity);
        void Update(T entity);
        void UpdateList(List<T> entity);
        void Delete(T entity);
        void DeleteList(List<T> entity);
        public void SaveChangesAsync();
        void BeginTransaction();
        void TransactionCommit();
        void TransactionRollback();
        void Dispose();
    }
}