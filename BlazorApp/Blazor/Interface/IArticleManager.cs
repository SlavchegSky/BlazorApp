using Blazor.Data;
using Blazor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Interface
{
    public interface IArticleManager
        {
            void Activate(SqlDbContext appDbContext);
            Task<int> Create(Article article);
            Task<int> Delete(int Id);
            Task<int> Count();
            Task<int> Save(Article article);
            Task<Article> GetById(int Id);

            //Task<List<Article>> ListAll(int skip, int take, string orderBy, string direction, string search);
            Task<List<Article>> ListAll();


    }
}
