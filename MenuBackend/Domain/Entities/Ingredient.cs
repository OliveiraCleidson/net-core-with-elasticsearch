namespace Domain.Entities;

public class Ingredient : Entity
{
    public Ingredient(Guid id, DateTime updatedAt, DateTime createdAt, string name)
    :base(id, createdAt, updatedAt)
    {
        _name = name;
    }
    private string _name;

    public string Name
    {
        get => _name;
        set  {
        _name = value;
        UpdateAt = DateTime.UtcNow;
        }
    }
}