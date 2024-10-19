using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.CollectionGenericObjects;
/// <summary>
/// Интерфейс описания действий для набора хранимых объектов
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ICollectionGenericObjects<T>
    where T : class
{
    /// <summary>
    /// Количество объектов в коллекции
    /// </summary>
    int Count { get; }

    int MaxCount { get; set; }

    /// <summary>
    /// Добавление объекта в коллекцию
    /// </summary>
    /// <param name="obj">Добавляемый объект</param>
    /// <returns>true-вставка прошла успешно, false - вставка не удалась</returns>
    bool Insert(T obj);
    /// <summary>
    /// Добавление объекта в коллекцию на конкретную позицию
    /// </summary>
    /// <param name="ojb">Добавляемый объект</param>
    /// <param name="position">Позиция</param>
    /// <returns>true-вставка прошла успешно, false - вставка не удалась</returns>
    bool Insert(T ojb, int position);
    /// <summary>
    /// Удаление объекта из коллекции с конкретной позиции
    /// </summary>
    /// <param name="position"></param>
    /// <returns>true-удаление прошло успешно, false - удаление не удалась</returns>
    bool Remove(int position);
    /// <summary>
    /// Получение объекта по позиции
    /// </summary>
    /// <param name="position">Позиция</param>
    /// <returns>Объект</returns>
    T? Get(int position);
    /// <summary>
    /// Получение типа коллекции
    /// </summary>
    CollectionType GetCollectionType { get; }

    /// <summary>
    /// Получение объектов коллекции по одному
    /// </summary>
    /// <returns></returns>
    IEnumerable<T?> GetItems();
}
