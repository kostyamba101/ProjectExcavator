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
    /// Изменение дополнительного цвета
    /// </summary>
    /// <param name="optionalColor"></param>
    public void SetOptionalColor(Color optionalColor)
    {
        OptionalColor = optionalColor;
    }

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

    public override string[] GetStringRepresentation()
    {
        return new string[] { nameof(EntityExcavator), Speed.ToString(), Weight.ToString(),
            MainColor.Name, OptionalColor.Name,
            HasBucket.ToString(), HasTube.ToString(), HasTracks.ToString()
        };
    }

    public static EntityExcavator? CreateEntityExcavator(string[] strs)
    {
        if (strs.Length != 8 || strs[0] != nameof(EntityExcavator))
        {
            return null;
        }

        return new EntityExcavator(Convert.ToInt32(strs[1]), Convert.ToDouble(strs[2]),
            Color.FromName(strs[3]), Color.FromName(strs[4]),
            Convert.ToBoolean(strs[5]), Convert.ToBoolean(strs[6]), Convert.ToBoolean(strs[7]));
    }
}
