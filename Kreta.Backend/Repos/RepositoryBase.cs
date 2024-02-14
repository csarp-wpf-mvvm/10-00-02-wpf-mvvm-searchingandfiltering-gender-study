using Kreta.Shared.Models;
using Kreta.Shared.Responses;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Kreta.Backend.Repos
{
    public abstract class RepositoryBase<TDbContext, TEntity> : IRepositoryBase<TEntity>
        where TDbContext : DbContext
        where TEntity : class, IDbEntity<TEntity>, new()
    {
        private readonly IDbContextFactory<TDbContext> _dbContextFactory;
        private readonly DbContext _dbContext;
        private DbSet<TEntity>? _dbSet;

        public RepositoryBase(IDbContextFactory<TDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
            TDbContext dbContext = _dbContextFactory.CreateDbContext();
            _dbContext = dbContext;
            // Itt megkapjuk az adatábzis táblát
            _dbSet = dbContext.Set<TEntity>();
        }
        public IQueryable<TEntity> FindAll()
        {
            if (_dbSet is null)
            {
                return Enumerable.Empty<TEntity>().AsQueryable().AsNoTracking();
            }
            return _dbSet.AsNoTracking();
        }
        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            if (_dbSet is null)
            {
                return Enumerable.Empty<TEntity>().AsQueryable().AsNoTracking();
            }
            return _dbSet.Where(expression).AsNoTracking();
        }
        public async Task<ControllerResponse> UpdateAsync(TEntity entity)
        {
            ControllerResponse response = new ControllerResponse();
            try
            {
                _dbContext.ChangeTracker.Clear();
                _dbContext.Entry(entity).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                response.AppendNewError(e.Message);
                response.AppendNewError($"{nameof(RepositoryBase<TDbContext, TEntity>)} osztály, {nameof(UpdateAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{entity} frissítése nem sikerült!");

            }
            return response;
        }
        public async Task<ControllerResponse> DeleteAsync(Guid id)
        {
            ControllerResponse response = new ControllerResponse();
            
            TEntity? entityToDelete = FindByCondition(e => e.Id==id).FirstOrDefault();
            
            if (entityToDelete is null || (entityToDelete is not null && !entityToDelete.HasId))
            {
                if (entityToDelete is not null )
                    response.AppendNewError($"{entityToDelete.Id} idével rendelkező entitás nem található!");
                response.AppendNewError("Az entitás törlése nem sikerült!");
            }
            else
            {
                try
                {
                    if (entityToDelete is not null)
                    {
                        _dbContext.ChangeTracker.Clear();
                        _dbContext.Entry(entityToDelete).State = EntityState.Deleted;
                        await _dbContext.SaveChangesAsync();
                    }
                }
                catch (Exception e)
                {
                    response.AppendNewError(e.Message);
                    response.AppendNewError($"{nameof(RepositoryBase<TDbContext, TEntity>)} osztály, {nameof(DeleteAsync)} metódusban hiba keletkezett");
                    if (entityToDelete is not null)
                        response.AppendNewError($"Az entitás id:{entityToDelete.Id}");
                    response.AppendNewError($"Az entitás törlése nem sikerült!");
                }
            }
            return response;
        }
        public async Task<ControllerResponse> CreateAsync(TEntity entity)
        {
            ControllerResponse response = new ControllerResponse();
            if (_dbSet is null)
            {
                response.AppendNewError($"{entity} osztály hozzáadása az adatbázishoz nem sikerült!");
            }
            else
            {
                try
                {
                    _dbSet.Add(entity);
                    await _dbContext.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    response.AppendNewError(e.Message);
                    response.AppendNewError($"{nameof(RepositoryBase<TDbContext, TEntity>)} osztály, {nameof(CreateAsync)} metódusban hiba keletkezett");
                    response.AppendNewError($"{entity} osztály hozzáadása az adatbázishoz nem sikerült!");
                }
            }
            return response;
        }


    }
}
