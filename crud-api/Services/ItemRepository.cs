using System.Collections.Concurrent;
using CrudApi.Models;

namespace CrudApi.Services;

public class ItemRepository
{
    private readonly ConcurrentDictionary<int, Item> _items = new();
    private int _nextId = 1;

    public IEnumerable<Item> GetAll() => _items.Values;

    public Item? GetById(int id) => _items.GetValueOrDefault(id);

    public Item Create(Item item)
    {
        item.Id = Interlocked.Increment(ref _nextId) - 1;
        item.CreatedAt = DateTime.UtcNow;
        _items[item.Id] = item;
        return item;
    }

    public Item? Update(int id, Item updated)
    {
        if (!_items.ContainsKey(id)) return null;
        updated.Id = id;
        _items[id] = updated;
        return updated;
    }

    public bool Delete(int id) => _items.TryRemove(id, out _);
}
