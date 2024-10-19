using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.Entities;

/// <summary>
/// Класс-сущность "Машина"
/// </summary>
public class EntityCar
{

    /// <summary>
    /// Скорость
    /// </summary>
    public int Speed { get; private set; }

    /// <summary>
    /// Вес
    /// </summary>
    public double Weight { get; private set; }

    /// <summary>
    /// Основной цвет
    /// </summary>
    public Color MainColor { get; private set; }

    /// <summary>
    /// Изменение основного цвета
    /// </summary>
    /// <param name="mainColor"></param>
    public void SetMainColor(Color mainColor)
    {
        MainColor = mainColor;
    }

    /// <summary>
    /// Шаг перемещения экскаватора, рассчитывается на основе его скорости и веса.
    /// </summary>
    public double Step => Speed * 100 / Weight;

    /// <summary>
    /// Конструктор сущности
    /// </summary>
    /// <param name="speed">скорость</param>
    /// <param name="weight">вес</param>
    /// <param name="mainColor">основной цвет</param>
    public EntityCar(int speed, double weight, Color mainColor)
    {
        Speed = speed;
        Weight = weight;
        MainColor = mainColor;
    }
    /// <summary>
    /// Получение строки со значениями свойств объекта класса-сущности
    /// </summary>
    /// <returns></returns>
    public virtual string[] GetStringRepresentation()
    {
        return new[] { nameof(EntityCar), Speed.ToString(), Weight.ToString(), MainColor.Name };
    }
    /// <summary>
    /// Создание объекта из массива строк
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public static EntityCar? CreateEntityCar(string[] strs)
    {
        if (strs.Length != 4 || strs[0] != nameof(EntityCar))
        {
            return null;
        }

        return new EntityCar(Convert.ToInt32(strs[1]), Convert.ToDouble(strs[2]), Color.FromName(strs[3]));
    }

}

