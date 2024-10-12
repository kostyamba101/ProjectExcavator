using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator
{
    /// <summary>
    /// Класс, отвечающий за прорисовку и перемещение объекта-сущности
    /// </summary>
    public class DrawningExcavator
    {
        /// <summary>
        /// Класс-сущность.
        /// </summary>
        public EntytyExcavator? EntytyExcavator { get; private set; }

        /// <summary>
        /// Ширина окна
        /// </summary>
        private int? _pictureWidth;
        /// <summary>
        /// Высота окна
        /// </summary>
        private int? _pictureHeight;

        /// <summary>
        /// Левая координата прорисовки экскаватора
        /// </summary>
        private int? _startPosX;

        /// <summary>
        /// Верхняя координата прорисовки экскаватора
        /// </summary>
        private int? _startPosY;

        /// <summary>
        /// Ширина прорисовки экскаватора
        /// </summary>
        private readonly int _drawningExcavatorWidth = 110;

        /// <summary>
        /// Высота прорисовки экскаватора
        /// </summary>
        private readonly int _drawingExcavatorHeight = 60;

        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">скорость</param>
        /// <param name="weight">вес</param>
        /// <param name="mainColor">главный цвет</param>
        /// <param name="optionalColor">дополнительный цвет</param>
        /// <param name="hasBusket">ковш</param>
        /// <param name="hasCab">кабина</param>
        /// <param name="hasTracks">гусеницы</param>
        public void Init(int speed, double weight, Color mainColor, Color optionalColor, bool hasBusket, bool hasCab, bool hasTracks)
        {
            EntytyExcavator = new EntytyExcavator();
            EntytyExcavator.Init(speed, weight, mainColor, optionalColor, hasBusket, hasCab, hasTracks);
            _pictureWidth = null;
            _pictureHeight = null;
            _startPosX = null;
            _startPosY = null;
        }

        /// <summary>
        /// Установка границ поля
        /// </summary>
        /// <param name="width">ширина</param>
        /// <param name="height">высота</param>
        /// <returns></returns>
        public bool SetPictureSize(int width, int height)
        {
            // TODO проверка, что объект "влезает" в размеры поля
            // если влезает, сохраняем границы и корректируем позицию объекта, если она была уже установлена
            if (_drawningExcavatorWidth > width || _drawingExcavatorHeight > height)
            {
                return false;
            }

            _pictureWidth = width;
            _pictureHeight = height;

            return true;
        }

        /// <summary>
        /// Установка позиции
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetPosition(int x, int y)
        {
            if (!_pictureHeight.HasValue || !_pictureWidth.HasValue)
            {
                return;
            }

            //TODO: если при установке объекта в эти координаты, он будет "выходить" за границы формы
            // то надо изменить координаты, чтобы он оставался в этих границах
            if (x + _drawningExcavatorWidth > _pictureWidth || y + _drawingExcavatorHeight > _pictureHeight)
            {
                _startPosX = _pictureWidth - _drawningExcavatorWidth;
                _startPosY = _pictureHeight - _drawingExcavatorHeight;
            }
            else
            {
                _startPosX = x;
                _startPosY = y;
            }
        }
        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction"></param>
        /// <returns>true - перемещение выполнено, false - перемещение невозможно </returns>
        public bool MoveTransport(DirectionType direction)
        {
            if (EntytyExcavator == null || !_startPosX.HasValue || !_startPosY.HasValue)
            {
                return false;
            }

            switch (direction)
            {
                //Влево
                case DirectionType.Left:
                    if (_startPosX.Value - EntytyExcavator.Step > 0)
                    {
                        _startPosX -= (int)EntytyExcavator.Step;
                    }
                    return true;
                //Вверх
                case DirectionType.Up:
                    if (_startPosY.Value - EntytyExcavator.Step > 0)
                    {
                        _startPosY -= (int)EntytyExcavator.Step;
                    }
                    return true;
                //Вправо
                case DirectionType.Right:
                    //TODO: проверить работу сдвига вправо
                    if (_startPosX.Value + EntytyExcavator.Step + _drawningExcavatorWidth < _pictureWidth)
                    {
                        _startPosX += (int)EntytyExcavator.Step;
                    }
                    return true;
                //Вниз
                case DirectionType.Down:
                    //TODO проверить работу сдвига вниз
                    if (_startPosY.Value + EntytyExcavator.Step + _drawingExcavatorHeight < _pictureHeight)
                    {
                        _startPosY += (int)EntytyExcavator.Step;
                    }
                    return true;
                default:
                    return false;

            }

        }

        /// <summary>
        /// Прорисовка объекта
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            if (EntytyExcavator == null || !_startPosX.HasValue || !_startPosY.HasValue)
            {
                return;
            }

            Pen pen = new(Color.Black);
            Brush mainBrush = new SolidBrush(EntytyExcavator.MainColor);
            Brush optionalBrush = new SolidBrush(EntytyExcavator.OptionalColor);

            // Границы экскаватора (основной корпус)           
            g.FillRectangle(mainBrush, _startPosX.Value, _startPosY.Value, _drawningExcavatorWidth, _drawingExcavatorHeight);
            g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value, _drawningExcavatorWidth, _drawingExcavatorHeight);

            // Кабина (если есть)
            if (EntytyExcavator.HasCab)
            {
                g.FillRectangle(optionalBrush, _startPosX.Value + 10, _startPosY.Value + 10, 30, 30);
                g.DrawRectangle(pen, _startPosX.Value + 10, _startPosY.Value + 10, 30, 30);
            }

            // Ковш (если есть)
            if (EntytyExcavator.HasBucket)
            {
                g.FillRectangle(optionalBrush, _startPosX.Value + _drawningExcavatorWidth - 20, _startPosY.Value + 20, 20, 10);
                g.DrawRectangle(pen, _startPosX.Value + _drawningExcavatorWidth - 20, _startPosY.Value + 20, 20, 10);
            }

            // Гусеницы (если есть)
            if (EntytyExcavator.HasTracks)
            {
                g.FillRectangle(optionalBrush, _startPosX.Value, _startPosY.Value + _drawingExcavatorHeight - 10, _drawningExcavatorWidth, 10);
                g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value + _drawingExcavatorHeight - 10, _drawningExcavatorWidth, 10);
            }

        }
    }
}
