using System.Linq.Expressions;
using Villa.Models;

namespace Villa.Repository.IRepository.IRepository
{
    public interface IVillaRepository : IRepositories<Villas>
    {
        Task <Villas>UpdateAsync(Villas entity);
    }
}
