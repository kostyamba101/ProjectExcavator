namespace ProjectExcavator.Entities;

/// <summary>
/// Класс-сущность "Экскаватор"
/// </summary>
public class EntityExcavator : EntityCar
{
    /// <summary>
    /// Базовый класс
    /// </summary>
    public EntityCar? EntytyCar { get; protected set; }

    /// <summary>
    /// Дополнительный цвет
    /// </summary>
    public Color OptionalColor { get; private set; }

    /// <summary>
    /// Ковш
    /// </summary>
    public bool HasBucket { get; private set; }

    /// <summary>
    /// Кабина
    /// </summary>
    public bool HasTube { get; private set; }

    /// <summary>
    /// Гусеницы
    /// </summary>
    public bool HasTracks { get; private set; }

    /// <summary>
    /// Конструктор экскаватора 
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="weight"></param>
    /// <param name="mainColor"></param>
    /// <param name="optionalColor"></param>
    /// <param name="hasBusket"></param>
    /// <param name="hasTube"></param>
    /// <param name="hasTracks"></param>
    public EntityExcavator(int speed, double weight, Color mainColor, Color optionalColor, bool hasBusket, bool hasTube, bool hasTracks) : base(speed, weight, mainColor)
    {
        OptionalColor = optionalColor;
        HasBucket = hasBusket;
        HasTube = hasTube;
        HasTracks = hasTracks;
    }
}
