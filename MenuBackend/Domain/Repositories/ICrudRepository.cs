using Domain.Entities;

namespace Domain.Repositories;

public interface ICrudRepository<T> where T : Entity
{
    Task<T> GetById(Guid id);
    Task<bool> Delete(Guid id);
    Task<T> Create(T entity);
    Task<T> Update(T entity);
}