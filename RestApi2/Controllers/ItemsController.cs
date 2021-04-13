using Microsoft.AspNetCore.Mvc;
using RestApi2.Models;
using RestApi2.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApi2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController<T> : ControllerBase where T : Item
    {
        private readonly IItemsService<T> _itemsService;
        public ItemsController(IItemsService<T> itemsService)
        {
            _itemsService = itemsService;
        }
        [HttpGet]
        public async Task<List<T>> GetAll()
        {
            return await _itemsService.GetAllItemsAsync();
        }
        [HttpGet("{id}")]
        public async Task<T> GetItem(int id)
        {
            return await _itemsService.GetItemAsync(id);
        }
        [HttpPost]
        public async Task AddItem(T t)
        {
           await _itemsService.AddItemAsync(t);
        }
        [HttpDelete("{id}")]
        public async Task DeleteItem(int id)
        {
           await _itemsService.DeleteItemAsync(id);
        }
        [HttpPut("{id}")]
        public async Task UpdateItem(int id,T t)
        {
           await _itemsService.UdateItemAsync( id, t);
        }

    }
}
