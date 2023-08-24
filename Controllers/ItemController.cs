using Microsoft.AspNetCore.Mvc;
using working_time.Models;
using working_time.Services;

namespace working_time.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ItemService _itemService;

        public ItemController(ItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public IEnumerable<Item> GetAll()
        {
            return _itemService.GetAllItems();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _itemService.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            _itemService.AddItem(item);
            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Item item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _itemService.UpdateItem(item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _itemService.DeleteItem(id);
            return NoContent();
        }
    }
}
