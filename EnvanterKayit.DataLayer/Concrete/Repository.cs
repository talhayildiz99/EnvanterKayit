using EnvanterKayit.DataLayer.Abstract;
using EnvanterKayit.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EnvanterKayit.DataLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        internal DatabaseContext _Context;
        internal DbSet<T> _DbSet;
        public Repository(DatabaseContext context)
        {
            _Context = context;
            _DbSet = _Context.Set<T>();
        }

        public void Add(T entity)
        {
            _DbSet.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
            await _DbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _DbSet.Remove(entity);
        }

        public T Find(int id)
        {
            return _DbSet.Find(id);
        }

        public async Task<T> FindAsync(int id)
        {
            return await _DbSet.FindAsync(id);
        }

        public T Get(Expression<Func<T, bool>> expressions)
        {
            return _DbSet.FirstOrDefault(expressions);
        }

        public List<T> GetAll()
        {
            return _DbSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expressions)
        {
            return _DbSet.Where(expressions).ToList();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _DbSet.ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expressions)
        {
            return await _DbSet.Where(expressions).ToListAsync();
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> expressions)
        {
            return _DbSet.FirstOrDefaultAsync(expressions);
        }

        public int Save()
        {
            return _Context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _Context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _Context.Update(entity);
        }
    }
}
