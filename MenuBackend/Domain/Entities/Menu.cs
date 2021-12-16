namespace Domain.Entities;

public class Menu : Entity
{
    public Menu() : base()
        => _pizzas = new List<Pizza>();

    public Menu(Guid id, DateTime createdAt, DateTime updatedAt, ICollection<Pizza> pizzas)
        : base(id, createdAt, updatedAt)
        => _pizzas = pizzas;
    

    private ICollection<Pizza> _pizzas;
    private string _title;

    public string Title
    {
        get => _title;
        set
        {
            _title = value;
            UpdateAt = DateTime.UtcNow;
        }
    }

    public ICollection<Pizza> Pizzas
    {
        get => _pizzas;
        private set
        {
            _pizzas = value;
            UpdateAt = DateTime.UtcNow;
        }
    }

    public void AddPizza(Pizza pizza)
    {
        _pizzas.Add(pizza);
        UpdateAt = DateTime.UtcNow;
    }

    public void AddPizzas(ICollection<Pizza> pizzas)
    {
        foreach (var pizza in pizzas)
        {
            _pizzas.Add(pizza);
        }

        UpdateAt = DateTime.UtcNow;
    }
}