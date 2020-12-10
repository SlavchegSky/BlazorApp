using Blazor.Data;
using Blazor.Models;
using Blazor.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Controller
{
    public class IArticleController : IArticleManager

    {

        private readonly SqlDbContext _appDbContext;
        public IArticleController(SqlDbContext appDbContext)
        {

            _appDbContext = appDbContext;
        }

        public Task<int> Create(Article article)
        {
            _appDbContext.Article.Add(article);
            _appDbContext.SaveChanges();
            return Task.FromResult(article.ID);
        }

        public Task<int> Delete(int Id)
        {
            var A = _appDbContext.Article.Where(X => X.ID == Id).FirstOrDefault();
            _appDbContext.Article.Remove(A);
            _appDbContext.SaveChanges();
            return Task.FromResult(Id);
        }

        public Task<int> Save(Article article)
        {
            if (article.ID == default)
                _appDbContext.Entry(article).State = EntityState.Added;
            else
                _appDbContext.Entry(article).State = EntityState.Modified;
            _appDbContext.SaveChanges();

            return Task.FromResult(article.ID);
        }

        public Task<Article> GetById(int Id)
        {
            var A = _appDbContext.Article.Where(X => X.ID == Id).FirstOrDefault();
            return Task.FromResult(A);
        }

        public Task<List<Article>> ListAll()
        {
            var results = _appDbContext.Article;
                
                return Task.FromResult(results.ToList());
        }

    }
}
