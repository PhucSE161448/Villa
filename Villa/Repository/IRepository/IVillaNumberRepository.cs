using Villa.Models;

namespace Villa.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepositories<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
