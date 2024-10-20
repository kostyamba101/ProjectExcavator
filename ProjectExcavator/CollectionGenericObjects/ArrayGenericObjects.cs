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
public class ArrayGenericObjects<T> : ICollectionGenericObjects<T>
    where T : class
{
    /// <summary>
    /// Массив объектов, которые храним
    /// </summary>
    private T?[] _collection;
    public int Count => _collection.Length;

    public int MaxCount
    {
        get
        {
            return _collection.Length;
        }
        set
        {
            if (value > 0)
            {
                _collection = new T?[value];
            }
        }


    }

    public CollectionType GetCollectionType => CollectionType.Massive;

    /// <summary>
    /// Конструктор
    /// </summary>
    public ArrayGenericObjects()
    {
        _collection = Array.Empty<T>();
    }

    public T? Get(int position)
    {
        if (position < 0 || position >= Count)
        {
            throw new PositionOutOfCollectionException(position);
        }
        if (_collection[position] == null)
        {
            throw new ObjectNotFoundException(position);
        }
        return _collection[position];
    }

    public int Insert(T obj, IEqualityComparer<T?>? comparer = null)
    {
        return Insert(obj, 0, comparer);
    }

    public int Insert(T obj, int position, IEqualityComparer<T?>? comparer = null)
    {
        if (position < 0 || position >= _collection.Length)
        {
            throw new PositionOutOfCollectionException(position);
        }

        if (comparer != null)
        {
            if (_collection.Contains(obj, comparer))
            {
                throw new AlreadyInCollectionException();
            }
        }

        for (int i = position; i < Count; i++)
        {
            if (_collection[i] == null)
            {
                _collection[i] = obj;
                return i;
            }
        }

        for (int i = position + 1; i < _collection.Length; i++)
        {
            if (_collection[i] == null)
            {
                _collection[i] = obj;
                return i;
            }
        }

        for (int i = position - 1; i >= 0; i--)
        {
            if (_collection[i] == null)
            {
                _collection[i] = obj;
                return i;
            }
        }
        throw new CollectionOverflowException(Count);
    }

    public T? Remove(int position)
    {
        if (position < 0 || position >= _collection.Length)
        {
            throw new PositionOutOfCollectionException(position);
        }

        if (_collection[position] == null)
        {
            throw new ObjectNotFoundException(position);
        }

        T? obj = _collection[position];
        _collection[position] = null;
        return obj;
    }

    public IEnumerable<T?> GetItems()
    {
        for (int i = 0; i < _collection.Length; ++i)
        {
            yield return _collection[i];
        }
    }

    public void CollectionSort(IComparer<T?> comparer)
    {
        Array.Sort(_collection, comparer);
    }
}

