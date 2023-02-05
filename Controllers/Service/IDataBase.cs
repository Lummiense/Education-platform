﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Models.Entities;

namespace Service
{
    public interface IDataBase
    {
        Task<uint> Add<T>(T newEntity) where T : class, IEntity;
        List<T> GetAll<T>() where T : class, IEntity;
        Task<int> SaveChangeAsync();
    }
}