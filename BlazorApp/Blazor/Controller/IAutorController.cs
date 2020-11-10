using Blazor.Data;
using Blazor.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Controller
{
    public class IAutorController
    {
        private readonly SqlDbContext _appDbContext;
        public IAutorController(SqlDbContext appDbContext)
        {

            _appDbContext = appDbContext;
        }

        public Task<int> Count()
        {
            return Task.FromResult(_appDbContext.Autors.Count());
        }

        public Task<int> Create(Autor autor)
        {
            _appDbContext.Autors.Add(autor);
            _appDbContext.SaveChanges();
            return Task.FromResult(autor.ID);
        }

        public Task<int> Delete(int Id)
        {
            var A = _appDbContext.Autors.Where(X => X.ID == Id).FirstOrDefault();
            _appDbContext.Autors.Remove(A);
            _appDbContext.SaveChanges();
            return Task.FromResult(Id);
        }

        public Task<Autor> GetById(int Id)
        {
            var A = _appDbContext.Autors.Where(X => X.ID == Id).FirstOrDefault();
            return Task.FromResult(A);
        }

        public Task<List<Autor>> ListAll()
        {
            var results = _appDbContext.Autors;

            return Task.FromResult(results.ToList());
        }

        public Task<int> Save(Autor autor)
        {
            if (autor.ID == default)
                _appDbContext.Entry(autor).State = EntityState.Added;
            else
                _appDbContext.Entry(autor).State = EntityState.Modified;
            _appDbContext.SaveChanges();

            return Task.FromResult(autor.ID);
        }
    }
}
