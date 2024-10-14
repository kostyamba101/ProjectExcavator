using System;
using System.Collections.Generic;
using System.Linq;
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

}

