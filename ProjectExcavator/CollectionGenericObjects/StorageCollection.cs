using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.CollectionGenericObjects;
/// <summary>
/// Класс-хранилище коллекций
/// </summary>
/// <typeparam name="T"></typeparam>
public class StorageCollection<T>
     where T : class
{
    /// <summary>
    /// Словарь(хранилище) с коллекциями
    /// </summary>
    readonly Dictionary<string, ICollectionGenericObjects<T>> _storages;
    /// <summary>
    /// Возвращение списка названий коллекций
    /// </summary>
    public List<string> Keys => _storages.Keys.ToList();
    /// <summary>
    /// Конструктор
    /// </summary>
    public StorageCollection()
    {
        _storages = new Dictionary<string, ICollectionGenericObjects<T>>();
    }
    /// <summary>
    /// Добавление коллекции в хранилище
    /// </summary>
    /// <param name="name">Название коллекции</param>
    /// <param name="collectionType">Тип коллекции</param>
    public void AddCollection(string name, CollectionType collectionType)
    {
        if (name == null || _storages.ContainsKey(name))
        {
            return;
        }
        switch (collectionType)
        {
            case CollectionType.None:
                return;
            case CollectionType.List:
                _storages[name] = new ListGenericObjects<T>();
                return;
            case CollectionType.Massive:
                _storages[name] = new ArrayGenericObjects<T>();
                return;
        }
    }
    /// <summary>
    /// Удаление коллекции
    /// </summary>
    /// <param name="name">Название коллекции</param>
    public void DelCollection(string name)
    {
        if (_storages.ContainsKey(name))
        {
            _storages.Remove(name);
        }
        

    }
    /// <summary>
    /// Доступ к коллекции
    /// </summary>
    /// <param name="name">Название коллекции</param>
    /// <returns></returns>
    public ICollectionGenericObjects<T>? this[string name]
    {
        get
        {
            if (name == null || !_storages.ContainsKey(name))
            {
                return null;
            }
            return _storages[name];
        }
    }


}
