namespace Shop.Application;

public class ShowAllItem
{
    private readonly IItemRepository repository;

    public ShowAllItem(IItemRepository repository)
    {
        this.repository = repository;
    }

    public List<Item> Execute()
    {
        return repository.GetAll();
    }
}