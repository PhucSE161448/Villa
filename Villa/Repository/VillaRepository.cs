using System.Linq;
using System.Linq.Expressions;
using Villa.Data;
using Villa.Models;
using Villa.Repository.IRepository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Villa.Repository
{
    public class VillaRepository : Repository<Villas>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public async Task<Villas> UpdateAsync(Villas entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
