public class GenericRepository<T> where T : class
{
    private List<T> _data;

    public GenericRepository()
    {
        _data = new List<T>();
    }

    public List<T> GetAll()
    {
        return _data;
    }

    public T GetById(int id)
    {
        return _data.Find(item => GetId(item) == id);
    }

    public void Insert(T entity)
    {
        _data.Add(entity);
    }

    public void Update(T entity)
    {
        var existingEntity = _data.Find(item => GetId(item) == GetId(entity));
        if (existingEntity != null)
        {
            _data.Remove(existingEntity);
            _data.Add(entity);
        }
    }

    public void Delete(int id)
    {
        var entityToDelete = _data.Find(item => GetId(item) == id);
        if (entityToDelete != null)
        {
            _data.Remove(entityToDelete);
        }
    }

    private int GetId(T entity)
    {
        return (int)entity.GetType().GetProperty("Id").GetValue(entity);
    }

    public void Save()
    {
        Console.WriteLine("Save operation (simulated) completed.");
        Console.WriteLine();
    }
}