using Shop.Domain;

namespace Shop.Application;

public class FakeItemRepository : IItemRepository
{
    public List<Item> GetAll()
    {
        return new List<Item>
        {
            new Item(1, "Silver Ring", 499),
            new Item(2, "Gold Necklace", 1299),
            new Item(3, "Pearl Earrings", 799)
        };
    }
}