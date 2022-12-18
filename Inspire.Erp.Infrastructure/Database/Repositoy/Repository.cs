
using IInspire.Erp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;



namespace Inspire.Erp.Infrastructure.Database.Repositoy
{
    public class Repository<T> : IRepository<T>, IDisposable where T : class
    {
        private readonly InspireErpDBContext context;
        private IDbContextTransaction dbContextTransaction;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public Repository(InspireErpDBContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }



        public void BeginTransaction()
        {
            dbContextTransaction = context.Database.BeginTransaction();

        }

        public IQueryable<T> GetWithInclude(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = this.GetAsQueryable().Where(predicate);
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public void TransactionCommit()
        {
            dbContextTransaction.Commit();
        }



        public void TransactionRollback()
        {
            dbContextTransaction.Rollback();
        }

        public IQueryable<T> GetAsQueryable()
        {
            return entities.AsQueryable();
        }
        //public T Get(long id)
        //{
        //    return entities.SingleOrDefault(s => s.Id == id);
        //}
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }



        public void InsertList(List<T> entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.AddRange(entity);
            context.SaveChanges();
        }

        public void DeleteList(List<T> entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.RemoveRange(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void UpdateList(List<T> entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.UpdateRange(entity);
            context.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public void SaveChangesAsync()
        {
            context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }



        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}