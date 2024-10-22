using ProjectExcavator.Drawnings;
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

    /// <summary>
    /// Максимальное количество объектов в коллекции
    /// </summary>
    int MaxCount { get; set; }

    /// <summary>
    /// Добавление объекта в коллекцию
    /// </summary>
    /// <param name="obj">Добавляемый объект</param>
    /// <param name="comparer">Сравнение двух объектов</param>
    /// <returns>true-вставка прошла успешно, false - вставка не удалась</returns>
    int Insert(T obj, IEqualityComparer<T?>? comparer = null);
    /// <summary>
    /// Добавление объекта в коллекцию на конкретную позицию
    /// </summary>
    /// <param name="obj">Добавляемый объект</param>
    /// <param name="position">Позиция</param>
    /// <param name="comparer">Сравнение двух объектов</param>
    /// <returns>true-вставка прошла успешно, false - вставка не удалась</returns>
    int Insert(T obj, int position, IEqualityComparer<T?>? comparer = null);
    /// <summary>
    /// Удаление объекта из коллекции с конкретной позиции
    /// </summary>    
    /// <param name="position">Позиция</param>    
    /// <returns>true-удаление прошло успешно, false - удаление не удалась</returns>
    T? Remove(int position);
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

    /// <summary>
    /// Сортировка коллекции
    /// </summary>
    /// <param name="comparer">Сравниватель объектов</param>
    void CollectionSort(IComparer<T?>comparer);
}
