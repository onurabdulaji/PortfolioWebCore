using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLAyer.Repositories.Abstracts
{
    public interface IGenericRepository<T> where T : class
    {
        // Async methods

        Task AddAsync(T t);
        Task UpdateAsync(T t);
        Task DeleteAsync(T t);

        // Normal methods
        void Add(T t);
        void Update(T t);
        void Delete(T t);

        // List Async And Normal methods
        List<T> GetListAll();
        Task<T> GetListAllAsync();

        //Linq Commands

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp);
        IQueryable<T> Where(Expression<Func<T, bool>> exp);

        //Find

        Task<T> GetByIdAsync(int id);
        void GetById(int id);
    }


}
