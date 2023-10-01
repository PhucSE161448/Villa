using System.Linq;
using System.Linq.Expressions;
using Villa.Data;
using Villa.Models;
using Villa.Repository.IRepository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Villa.Repository.IRepository;

namespace Villa.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaNumberRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
