namespace HotelCalifornia
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Delete(T entity);
        List<T> Read();
        void Update(T entity);

        void Save();
    }
}

