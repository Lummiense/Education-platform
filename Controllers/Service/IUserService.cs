using System.Collections.Generic;
using System.Threading.Tasks;
using api.Entities;

namespace api.Service
{
    public interface IUserService
    {
        Task<uint> Add(UserEntity user);
        List<UserEntity> GetAll();
    }
}