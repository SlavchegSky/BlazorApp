using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Interface
{
    public interface IManagerCRUD<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        Task<TEntity> GetById(int Id);
        Task<List<TEntity>> ListAll();
    }
}
