using E_Study.Data.Context;
using E_Study.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Study.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region Properties
        protected readonly DatabaseContext _context;

        protected DbSet<TEntity> DbSet
        {
            get
            {
                return _context.Set<TEntity>();
            }
        }
        #endregion

        public Repository(DatabaseContext context)
        {
            _context = context;
        }
        #region Methods: Create/Update/Delete/Save
        public TEntity Create(TEntity model)
        {
            try 
            {
                DbSet.Add(model);
                Save();
                return model;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public List<TEntity> Create(List<TEntity> models)
        {
            try
            {
                DbSet.AddRange(models);
                Save();
                return models;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public bool Update(TEntity model)
        {
            try 
            {
                EntityEntry<TEntity> entry = NewMethod(model);
                DbSet.Attach(model);
                entry.State = EntityState.Modified;
                return Save() > 0;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        private EntityEntry<TEntity> NewMethod(TEntity model)
        {
            return _context.Entry(model);
        }

        public bool Update(List<TEntity> models)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> CreateAsync(TEntity model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TEntity model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TEntity Find(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, object> includes)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, object> includes)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }
        public Task<bool> UpdateAsync(TEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
