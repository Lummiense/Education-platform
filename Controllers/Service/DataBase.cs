using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Entities;

namespace api.Service
{
    public class DataBase:IDataBase
    {
        private readonly DataContext _context;

        public DataBase(DataContext context)
        {
            _context = context;
        }
        public async Task<uint> Add<T>(T newEntity) where T : class, IEntity
        {
            var entity = await _context.Set<T>().AddAsync(newEntity);
            return entity.Entity.Id;
        }

        public List<T> GetAll<T>() where T : class, IEntity
        {
            return _context.Set<T>().ToList();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}