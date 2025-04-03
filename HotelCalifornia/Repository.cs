namespace HotelCalifornia
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        private readonly IDataStorage<T>? _storage;

        public Repository(IDataStorage<T> storage)
        {
            _storage = storage;
        }
        
        public void Create(T entity)
        {
            _storage.Add(entity);
        }

        public void Delete(T entity)
        {
            _storage.Delete(entity.Id);
        }

        public List<T> Read()
        {
            return new List<T>(_storage.GetAll());
        }

        public void Update(T entity)
        {
            var index = _storage.GetAll().FindIndex(e => e.Id == entity.Id);
            _storage.GetAll()[index] = entity;
        }
        
        public void Save()
        {
            _storage?.Save();
        }
    }
}
