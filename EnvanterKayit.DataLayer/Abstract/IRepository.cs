using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EnvanterKayit.DataLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        //Standart Metodlar
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expressions);
        T Get(Expression<Func<T, bool>> expressions);
        T Find(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        int Save();

        //Asenkron Metodlar
        Task<int> SaveAsync();
        Task<T> FindAsync(int id);
        Task<T> GetAsync(Expression<Func<T, bool>> expressions);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expressions);
        Task AddAsync(T entity);
    }
}
