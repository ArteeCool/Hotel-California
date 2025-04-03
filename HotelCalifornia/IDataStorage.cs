using System.Collections;

namespace HotelCalifornia;

public interface IDataStorage<T>
{
    void Add(T entity);
    void Update(T entity);
    void Delete(String id);
    T? GetById(String id);
    List<T> GetAll();
    void Save();
}