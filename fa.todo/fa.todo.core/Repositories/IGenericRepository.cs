﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fa.todo.core.Models;

namespace fa.todo.core.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> GetAll();

        Task<IEnumerable<TEntity>> GetAllAsync();

        TEntity GetById(int id);
        
        Task<TEntity> GetByIdAsync(int id);

        int Create(TEntity entity);
        
        Task<int> CreateAsync(TEntity entity);

        bool Update(TEntity entity);
        
        Task<bool> UpdateAsync(TEntity entity);

        bool Delete(TEntity entity);

        Task<bool> DeleteAsync(TEntity entity);
    }
}