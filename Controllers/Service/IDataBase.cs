using System.Collections.Generic;
using System.Threading.Tasks;
using api.Entities;

namespace api.Service
{
    public interface IDataBase
    {
        Task<uint> Add<T>(T newEntity) where T : class, IEntity;
        List<T> GetAll<T>() where T : class, IEntity;
        Task<int> SaveChangeAsync();
    }
}