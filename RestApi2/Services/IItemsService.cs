using RestApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi2.Services
{
    public interface IItemsService<T> where T : Item
    {
        Task<T> GetItemAsync(int id);

        Task<List<T>> GetAllItemsAsync();

        Task AddItemAsync(T t);

        Task DeleteItemAsync(int id);

        Task UdateItemAsync(int id, T t);    
    }
}
