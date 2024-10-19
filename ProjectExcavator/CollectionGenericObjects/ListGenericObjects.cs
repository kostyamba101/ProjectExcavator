using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.CollectionGenericObjects;
/// <summary>
/// Параметризованный набор объектов
/// </summary>
/// <typeparam name="T">Параметр: ограничение - ссылочный тип</typeparam>
public class ListGenericObjects<T> : ICollectionGenericObjects<T>
    where T : class
{
    /// <summary>
    /// Список объектов, которые храним
    /// </summary>
    private readonly List<T> _collection;
    /// <summary>
    /// Максимально допустимое число объектов в списке
    /// </summary>
    private int _maxCount;

    public int Count => _collection.Count;

    public int MaxCount
    {
        get
        {
            return Count;
        }
        set
        {
            if (value > 0)
            {
                _maxCount = value;
            }
        }

    }

    public CollectionType GetCollectionType => CollectionType.List;

    public ListGenericObjects()
    {
        _collection = new();
    }

    public T? Get(int position)
    {
        if (position >= Count || position < 0)
        {
            return null;
        }
        return _collection[position];
    }

    public bool Insert(T obj)
    {
        if (Count + 1 > _maxCount)
        {
            return false;
        }
        _collection.Add(obj);

        return true;
    }

    public bool Insert(T ojb, int position)
    {

        if (Count + 1 > _maxCount)
        {
            return false;
        }

        if (position < 0 || position > Count)
        {
            return false;
        }

        _collection.Insert(position, ojb);

        return true;
    }

    public bool Remove(int position)
    {

        if (position < 0 || position > Count)
        {
            return false;
        }
        _collection.RemoveAt(position);
        return true;
    }

    public IEnumerable<T?> GetItems()
    {
        for (int i = 0; i < Count; ++i)
        {
            yield return _collection[i];
        }
    }
}
