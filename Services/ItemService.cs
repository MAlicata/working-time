using working_time.Data;
using working_time.Models;

namespace working_time.Services
{
    public class ItemService
    {
        private readonly GenericRepository<Item> _repository;

        public ItemService(GenericRepository<Item> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _repository.GetAll();
        }

        public Item GetItemById(int id)
        {
            return _repository.GetById(id);
        }

        public void AddItem(Item item)
        {
            _repository.Add(item);
        }

        public void UpdateItem(Item item)
        {
            _repository.Update(item);
        }

        public void DeleteItem(int id)
        {
            _repository.Delete(id);
        }
    }
}
