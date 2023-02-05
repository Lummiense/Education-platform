using System.Collections.Generic;
using System.Threading.Tasks;
using Models.Entities;

namespace Service
{
    public interface IUserService
    {
        Task<uint> Add(UserEntity user);
        List<UserEntity> GetAll();
    }
}