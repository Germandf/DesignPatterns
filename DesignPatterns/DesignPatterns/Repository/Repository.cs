using DesignPatterns.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.DesignPatterns.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly DesignPatternsContext _context;
    private DbSet<TEntity> _entity;

    public Repository(DesignPatternsContext context)
    {
        _context = context;
        _entity = _context.Set<TEntity>();
    }

    public void Add(TEntity entity) => _entity.Add(entity);

    public void Delete(int id) => _entity.Remove(_entity.Find(id)!);

    public IEnumerable<TEntity> Get() => _entity.ToList();

    public TEntity? Get(int id) => _entity.Find(id);

    public void Save() => _context.SaveChanges();

    public void Update(TEntity entity) => _entity.Update(entity);
}
