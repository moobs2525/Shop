using Shop.Domain;

namespace Shop.Application;

public class ShowAllItems
{
    private readonly IItemRepository repository;

    public ShowAllItems(IItemRepository repository)
    {
        this.repository = repository;
    }

    public List<Item> Execute()
    {
        return repository.GetAll();
    }
}