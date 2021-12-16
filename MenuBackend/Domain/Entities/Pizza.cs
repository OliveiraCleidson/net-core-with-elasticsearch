namespace Domain.Entities;

public class Pizza : Entity
{
    public Pizza()
    :base()
    {
        _ingredients = new List<Ingredient>();
        _name = String.Empty;
        _price = 15;
    }

    public Pizza(Guid id, DateTime updatedAt, DateTime createdAt, string name, ICollection<Ingredient> ingredients,
        decimal price)
    :base(id, updatedAt, createdAt){
        _name = name;
        _ingredients = ingredients;
        _price = price;
    }
    private string _name;
    private ICollection<Ingredient> _ingredients;
    private decimal _price;

    public string Name
    {
        get => _name;
        set { _name = value; UpdateAt = DateTime.UtcNow; }
    }

    public ICollection<Ingredient> Ingredients
    {
        get => _ingredients;
        private set { _ingredients = value; UpdateAt = DateTime.UtcNow; }
    }

    public decimal Price
    {
        get => _price;
        set
        {
            _price = value;
            UpdateAt = DateTime.UtcNow;
        }
    }

    public void AddIngredient(Ingredient ingredient)
    {
        _ingredients.Add(ingredient);
        UpdateAt = DateTime.UtcNow;
    }
    
    public void AddIngredients(ICollection<Ingredient> ingredients)
    {
        foreach (var ingredient in ingredients) _ingredients.Add(ingredient);

        UpdateAt = DateTime.UtcNow;
    }
}