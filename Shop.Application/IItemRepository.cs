using Shop.Domain;

namespace Shop.Application;


public interface IItemRepository
{
    List<Item> GetAll();
}