using Blazor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Interface
{
    public interface IAutorManager
        {
            Task<int> Create(Autor autor);
            Task<int> Delete(int Id);
            Task<int> Save(Autor autor);
            Task<Autor> GetById(int Id);
            Task<List<Autor>> ListAll();


    }
}
