using Blazor.Data;
using Blazor.Models;
using Blazor.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Blazor.Controller
{
    public class IController<TEntity> : IManagerCRUD<TEntity> where TEntity : class

    {
        private readonly SqlDbContext _appDbContext;
        private readonly DbSet<TEntity> _dbSet;
        public IController(SqlDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _dbSet.Add(entity);
            _appDbContext.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
                _dbSet.Remove(entity);
                _appDbContext.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            _appDbContext.Entry(entity).State = EntityState.Modified;
            _appDbContext.SaveChanges();

        }

        public Task<TEntity> GetById(int Id)
        {
            return Task.FromResult(_dbSet.Find(Id));
        }

        public Task<List<TEntity>> ListAll()
        {
            return Task.FromResult(_dbSet.AsNoTracking().ToList());
        }
    }
}
