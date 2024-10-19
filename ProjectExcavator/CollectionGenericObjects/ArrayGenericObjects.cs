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
        if (position < 0 || position >= _collection.Length)
        {
            return null;
        }
        return _collection[position];
    }

    public bool Insert(T obj)
    {
        for (int i = 0; i < _collection.Length; i++)
        {
            if (_collection[i] == null)
            {
                _collection[i] = obj;
                return true;
            }
        }
        return false;
    }

    public bool Insert(T obj, int position)
    {
        if (position < 0 || position >= _collection.Length)
        {
            return false;
        }

        // Если позиция свободна, вставляем объект
        if (_collection[position] == null)
        {
            _collection[position] = obj;
            return true;
        }

        // Поиск ближайшего свободного места после позиции
        for (int i = position + 1; i < _collection.Length; i++)
        {
            if (_collection[i] == null)
            {
                _collection[i] = obj;
                return true;
            }
        }

        // Поиск ближайшего свободного места до позиции
        for (int i = position - 1; i >= 0; i--)
        {
            if (_collection[i] == null)
            {
                _collection[i] = obj;
                return true;
            }
        }
        return false;
    }

    public bool Remove(int position)
    {
        if (position < 0 || position >= _collection.Length)
        {
            return false;
        }

        if (_collection[position] != null)
        {
            _collection[position] = null;
            return true;
        }
        return false;
    }

    public IEnumerable<T?> GetItems()
    {
        for (int i = 0; i < _collection.Length; ++i)
        {
            yield return _collection[i];
        }
    }
}
