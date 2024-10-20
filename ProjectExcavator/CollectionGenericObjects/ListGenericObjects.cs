using ProjectExcavator.Drawnings;
using ProjectExcavator.Exceptions;
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
            throw new PositionOutOfCollectionException(position);
        }
        return _collection[position];
    }

    public int Insert(T obj, IEqualityComparer<T?>? comparer = null)
    {
        if (comparer != null)
        {
            if (_collection.Contains(obj, comparer))
            {
                throw new AlreadyInCollectionException();
            }
        }

        if (Count == _maxCount)
        {
            throw new CollectionOverflowException(Count);
        }

        _collection.Add(obj);
        return Count;
    }

    public int Insert(T obj, int position, IEqualityComparer<T?>? comparer = null)
    {
        if (comparer != null)
        {
            if (_collection.Contains(obj, comparer))
            {
                throw new AlreadyInCollectionException();
            }
        }

        if (Count == _maxCount)
        {
            throw new CollectionOverflowException(Count);
        }

        if (position >= Count || position < 0)
        {
            throw new PositionOutOfCollectionException(position);
        }

        _collection.Insert(position, obj);
        return position;


    }

    public T? Remove(int position)
    {

        if (position < 0 || position > Count)
        {
            throw new PositionOutOfCollectionException(position);
        }
        T? obj = _collection[position];
        _collection.RemoveAt(position);
        return obj;

    }

    public IEnumerable<T?> GetItems()
    {
        for (int i = 0; i < Count; ++i)
        {
            yield return _collection[i];
        }
    }

    public void CollectionSort(IComparer<T?> comparer)
    {
        _collection.Sort(comparer);
    }
}
