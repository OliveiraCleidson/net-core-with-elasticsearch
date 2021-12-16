namespace Domain.Entities;

public class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        UpdateAt = DateTime.UtcNow;
    }

    public Entity(Guid id, DateTime createdAt, DateTime updateAt)
    {
        Id = id;
        CreatedAt = createdAt;
        UpdateAt = updateAt;
    }
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdateAt { get; protected set;  }
}