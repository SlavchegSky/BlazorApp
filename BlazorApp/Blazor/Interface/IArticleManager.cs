using Blazor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Interface
{
    public interface IArticleManager
        {
            Task<int> Create(Article article);
            Task<int> Delete(int Id);
            Task<int> Save(Article article);
            Task<Article> GetById(int Id);
            Task<List<Article>> ListAll();
    }
}
