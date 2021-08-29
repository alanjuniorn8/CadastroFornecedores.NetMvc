using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CadastroFornecedores.Data;
using CadastroFornecedores.Models;
using CadastroFornecedores.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CadastroFornecedores.Repositories
{

    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly ApplicationDbContext DbContext;
        protected readonly DbSet<TEntity> DbSet;
        

        public Repository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = dbContext.Set<TEntity>();
        }
        
        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public virtual async Task Remover(Guid id)
        {
            //DbSet.Remove(await ObterPorId(id));
            //DbSet.Remove(await DbSet.FindAsync(id));
            DbSet.Remove(new TEntity { Id = id});
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await DbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            DbContext?.Dispose();
        }

    }
}
