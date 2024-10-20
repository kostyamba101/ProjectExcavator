﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.CollectionGenericObjects;
/// <summary>
/// Класс, хранящий информацию по коллекции
/// </summary>
public class CollectionInfo : IEquatable<CollectionInfo>
{
    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// Тип
    /// </summary>
    public CollectionType CollectionType { get; private set; }
    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// Разделитель для записи информации по объекту в файл
    /// </summary>
    private static readonly string _separator = "-";
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="name"></param>
    /// <param name="collectionType"></param>
    /// <param name="description"></param>
    public CollectionInfo(string name, CollectionType collectionType, string description)
    {
        Name = name;
        CollectionType = collectionType;
        Description = description;
    }
    /// <summary>
    /// Создание объекта из строки
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public static CollectionInfo? GetCollectionInfo(string data)
    {
        string[] strs = data.Split(_separator, StringSplitOptions.RemoveEmptyEntries);
        if (strs.Length < 1 || strs.Length > 3)
        {
            return null;
        }
        return new CollectionInfo(strs[0], (CollectionType)Enum.Parse(typeof(CollectionType), strs[1]),
            strs.Length > 2 ? strs[2] : string.Empty);
    }

    public override string ToString()
    {
        return Name + _separator + CollectionType + _separator + Description;
    }

    public bool Equals(CollectionInfo? other)
    {
        return Name == other?.Name;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as CollectionInfo);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}
