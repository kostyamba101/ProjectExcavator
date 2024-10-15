using ProjectExcavator.Drawnings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.CollectionGenericObjects;
/// <summary>
/// Абстракция компании, хранящий коллекции автомобилей
/// </summary>
public abstract class AbstractCompany
{
    /// <summary>
    /// Размер места(ширина)
    /// </summary>
    protected readonly int _placeSizeWidth = 210;
    /// <summary>
    /// Размер места(высота)
    /// </summary>
    protected readonly int _placeSizeHeight = 80;
    /// <summary>
    /// Ширина окна
    /// </summary>
    protected readonly int _pictureWidth;
    /// <summary>
    /// Высота окна
    /// </summary>
    protected readonly int _pictureHeight;
    /// <summary>
    /// Коллекция автомобилей
    /// </summary>
    protected ICollectionGenericObjects<DrawningCar>? _collection = null;
    /// <summary>
    /// Вычисление максимального количества элементов, которые можно разместить в окне
    /// </summary>
    private int GetMaxCount => _pictureWidth * _pictureHeight / (_placeSizeWidth * _placeSizeHeight);
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="picWidth">Ширина окна</param>
    /// <param name="picHeight">Высота окна</param>
    /// <param name="collection">Коллекция автомобилей</param>
    public AbstractCompany(int picWidth, int picHeight, ICollectionGenericObjects<DrawningCar> collection)
    {
        _pictureWidth = picWidth;
        _pictureHeight = picHeight;
        _collection = collection;
        _collection.SetMaxCount = GetMaxCount;
    }
    /// <summary>
    /// Перегрузка оператора сложения для класса
    /// </summary>
    /// <param name="company">Компания</param>
    /// <param name="car">Добавляемый объект</param>
    /// <returns></returns>
    public static bool operator +(AbstractCompany company, DrawningCar car)
    {
        return company._collection?.Insert(car) ?? false;
    }
    /// <summary>
    /// Перегрузка оператора удаления для класса
    /// </summary>
    /// <param name="company">Компания</param>
    /// <param name="position">Номер удаляемого объекта</param>
    /// <returns></returns>
    public static bool operator -(AbstractCompany company, int position)
    {
        return company._collection?.Remove(position) ?? false;
    }
    /// <summary>
    /// Получение случайного объекта из коллекции
    /// </summary>
    /// <returns></returns>
    public DrawningCar? GetRandomObject()
    {
        Random rnd = new Random();
        return _collection?.Get(rnd.Next(GetMaxCount));
    }
    /// <summary>
    /// Вывод всей коллекции
    /// </summary>
    /// <returns></returns>
    public Bitmap? Show()
    {
        Bitmap bitmap = new(_pictureWidth, _pictureHeight);
        Graphics graphics = Graphics.FromImage(bitmap);
        DrawBackground(graphics);

        SetObjectsPosition();
        for (int i = 0; i < (_collection?.Count ?? 0); ++i)
        {
            DrawningCar? obj = _collection?.Get(i);
            obj?.DrawTransport(graphics);

        }
        return bitmap;
    }
    /// <summary>
    /// Вывод заднего фона
    /// </summary>
    /// <param name="g"></param>
    protected abstract void DrawBackground(Graphics g);
    /// <summary>
    /// Расстановка объектов
    /// </summary>
    protected abstract void SetObjectsPosition();



}
