namespace ProjectExcavator
{
    /// <summary>
    /// Класс-сущность "Экскаватор"
    /// </summary>
    public class EntytyExcavator
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
        public bool HasCab { get; private set; }

        /// <summary>
        /// Гусеницы
        /// </summary>
        public bool HasTracks { get; private set; }

        /// <summary>
        /// Шаг перемещения экскаватора, рассчитывается на основе его скорости и веса.
        /// </summary>
        public double Step => Speed * 100 / Weight;

        /// <summary>
        /// Инициализирует объект экскаватора с заданными характеристиками.
        /// </summary>
        /// <param name="speed">скорость</param>
        /// <param name="weight">вес</param>
        /// <param name="mainColor">основной цвет</param>
        /// <param name="optionalColor">дополнительный цвет</param>
        /// <param name="hasBusket">ковш.</param>
        /// <param name="hasCab">кабина</param>
        /// <param name="hasTracks">гусениц</param>
        public void Init(int speed, double weight, Color mainColor, Color optionalColor, bool hasBusket, bool hasCab, bool hasTracks)
        {
            Speed = speed;
            Weight = weight;
            MainColor = mainColor;
            OptionalColor = optionalColor;
            HasBucket = hasBusket;
            HasCab = hasCab;
            HasTracks = hasTracks;
        }
    }

}
