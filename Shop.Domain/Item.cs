namespace Shop.Domain;

public class Item
{
    public int Id { get; }
    public string Description { get; }
    public decimal Price { get; }
    
    public Item(int id, string description, decimal price)
    {
        Id = id;
        Description = description;
        Price = price;
    }
}