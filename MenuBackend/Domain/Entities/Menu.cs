namespace Domain.Entities;

public class Menu : Entity
{
    public Menu(Guid id, DateTime createdAt, DateTime updatedAt, ICollection<Pizza> pizzas)
    :base(id, createdAt, updatedAt)
    {
        _pizzas = pizzas;
    }
    private ICollection<Pizza> _pizzas;

    public ICollection<Pizza> Pizzas
    {
        get => _pizzas;
        set {
        _pizzas = value;
        UpdateAt = DateTime.UtcNow;
        }
    }
}