using Microsoft.EntityFrameworkCore;
using Project.DataAccessLAyer.Concrete;
using Project.DataAccessLAyer.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLAyer.Repositories.Concretes
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Add(T t)
        {
            _context.Set<T>().Add(t);
            _context.SaveChanges();
        }

        public async Task AddAsync(T t)
        {
            await _context.Set<T>().AddAsync(t);
            await _context.SaveChangesAsync();
        }

        public void Delete(T t)
        {
            _context.Set<T>().Remove(t);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(T t)
        {
            await _context.Set<T>().ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            await _context.Set<T>().FirstOrDefaultAsync(exp);
            return null;
        }

        public void GetById(int id)
        {
            _context.Set<T>().Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            await _context.Set<T>().FindAsync(id);
            return null;
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<T> GetListAllAsync()
        {
            await _context.Set<T>().ToListAsync();
            return null;
        }

        public void Update(T t)
        {
            _context.Set<T>().Update(t);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(T t)
        {
            _context.Update(t);
            await _context.SaveChangesAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp);
        }
    }
}
