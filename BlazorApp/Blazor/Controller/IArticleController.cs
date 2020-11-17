using Blazor.Data;
using Blazor.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Controller
{
    public class IArticleController

    {

        private readonly SqlDbContext _appDbContext;
        public IArticleController(SqlDbContext appDbContext)
        {

            _appDbContext = appDbContext;
        }

        public Task<int> Count()
        {
            return Task.FromResult(_appDbContext.Article.Count());
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

        public Task<Article> GetById(int Id)
        {
            var A = _appDbContext.Article.Where(X => X.ID == Id).FirstOrDefault();
            return Task.FromResult(A);
        }

        public Task<List<Article>> ListAll()
        {
            var results = _appDbContext.Article;
                
                return Task.FromResult(results.ToList());

            //return Task.FromResult(_appDbContext.ArticleList
            //    .Where(X => string.IsNullOrEmpty(search) ? true : X.Title.Contains(search))
            //    .Skip(skip)
            //    .Take(take)
            //    .AsEnumerable()
            //    .OrderByWithDirection(orderBy, direction)
            //    .ToList());
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
    }
}
