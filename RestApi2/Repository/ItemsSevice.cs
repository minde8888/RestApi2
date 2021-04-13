using RestApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestApi2.Services;
using RestApi2.Data;
using Microsoft.EntityFrameworkCore;

public class ItemsSevice<T> : IItemsService<T> where T : Item
{
    private List<T> _items = new List<T>();
    private readonly MainContext _context;

    public ItemsSevice(MainContext context)
    {
        _context = context;
    }

    public async Task<T> GetItemAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id); ;
    }
    public async Task<List<T>> GetAllItemsAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }
    public async Task AddItemAsync(T t)
    {
        _context.Set<T>().Add(t);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteItemAsync(int id)
    {
        var item = await GetItemAsync(id);
        _context.Set<T>().Remove(item);
        await _context.SaveChangesAsync();
    }
    public async Task UdateItemAsync(int id, T t)
    {
        var item = await GetItemAsync(id);
        item.Name = t.Name;
        await _context.SaveChangesAsync();
    }

}

