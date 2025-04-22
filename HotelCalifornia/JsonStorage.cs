using System.Collections;
using System.Text.Json;

namespace HotelCalifornia;

public class JsonStorage<T> : IDataStorage<T> where T : IEntity
{
    private readonly String _filePath;
    private List<T> _items;
    
    public JsonStorage(String filePath)
    {
        _filePath = filePath;
        _items = LoadFromFile();
    }
    
    private List<T> LoadFromFile()
    {
        if (!File.Exists(_filePath))
            return new List<T>();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            IncludeFields = true // Если используете поля
        };

        string json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<T>>(json, options) ?? new List<T>();
    }
    
    public void Add(T entity)
    {
        entity.Id = _items.Count != 0 ? _items.Max(e => e.Id) + 1 : "1";
        _items.Add(entity);
    }
    
    public void Update(T entity)
    {
        var index = _items.FindIndex(e => e.Id == entity.Id);
        if (index != -1)
        {
            _items[index] = entity;
        }
    }

    public void Delete(String id)
    {
        var item = _items.FirstOrDefault(e => e.Id == id);
        if (item != null)
        {
            _items.Remove(item);
        }
    }
    
    public T? GetById(String id)
    {
        return _items.FirstOrDefault(e => e.Id == id);
    }
    
    public List<T> GetAll()
    {
        return _items;
    }
    
    public void Save()
    {
        var json = JsonSerializer.Serialize(_items, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        
        File.WriteAllText(_filePath, json);
    }
}