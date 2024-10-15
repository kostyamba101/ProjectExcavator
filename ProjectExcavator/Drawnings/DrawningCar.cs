using ProjectExcavator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.Drawnings;
/// <summary>
/// Класс, отвечающий за прорисовку и перемещение объекта-сущности
/// </summary>
public class DrawningCar
{
    /// <summary>
    /// Класс-сущность.
    /// </summary>
    public EntityCar? EntityCar { get; protected set; }

    /// <summary>
    /// Ширина окна
    /// </summary>
    private int? _pictureWidth;
    /// <summary>
    /// Высота окна
    /// </summary>
    private int? _pictureHeight;

    /// <summary>
    /// Левая координата прорисовки машины
    /// </summary>
    protected int? _startPosX;

    /// <summary>
    /// Верхняя координата прорисовки машины
    /// </summary>
    protected int? _startPosY;

    /// <summary>
    /// Ширина прорисовки машины
    /// </summary>
    private readonly int _drawningCarWidth = 80;

    /// <summary>
    /// Высота прорисовки машины
    /// </summary>
    private readonly int _drawingCarHeight = 70;
    /// <summary>
    /// Координата Х объекта
    /// </summary>
    public int? GetPosX => _startPosX;
    /// <summary>
    /// Координата У объекта
    /// </summary>
    public int? GetPosY => _startPosY;
    /// <summary>
    /// Ширина объекта
    /// </summary>
    public int GetWidth => _drawningCarWidth;
    /// <summary>
    /// Высота объекта
    /// </summary>
    public int GetHeight => _drawingCarHeight;

    /// <summary>
    /// Пустой конструктор
    /// </summary>
    private DrawningCar()
    {
        _pictureWidth = null;
        _pictureHeight = null;
        _startPosX = null;
        _startPosY = null;
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="speed">скорость</param>
    /// <param name="weight">вес</param>
    /// <param name="mainColor">главный цвет</param>
    public DrawningCar(int speed, double weight, Color mainColor) : this()
    {
        EntityCar = new EntityCar(speed, weight, mainColor);
        
    }

    /// <summary>
    /// Конструктор для наследников
    /// </summary>
    /// <param name="drawningCarWidth">Ширина</param>
    /// <param name="drawingCarHeight">Высота</param>
    protected DrawningCar(int drawningCarWidth, int drawingCarHeight) : this()
    {
       _drawningCarWidth = drawningCarWidth;
       _drawingCarHeight = drawingCarHeight;
    }

    /// <summary>
    /// Установка границ поля
    /// </summary>
    /// <param name="width">ширина</param>
    /// <param name="height">высота</param>
    /// <returns></returns>
    public bool SetPictureSize(int width, int height)
    {
        if (_drawningCarWidth > width || _drawingCarHeight > height)
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

        
        if (x + _drawningCarWidth > _pictureWidth || y + _drawingCarHeight > _pictureHeight)
        {
            _startPosX = _pictureWidth - _drawningCarWidth;
            _startPosY = _pictureHeight - _drawingCarHeight;
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
        if (EntityCar == null || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return false;
        }

        switch (direction)
        {
            //Влево
            case DirectionType.Left:
                if (_startPosX.Value - EntityCar.Step > 0)
                {
                    _startPosX -= (int)EntityCar.Step;
                }
                return true;
            //Вверх
            case DirectionType.Up:
                if (_startPosY.Value - EntityCar.Step > 0)
                {
                    _startPosY -= (int)EntityCar.Step;
                }
                return true;
            //Вправо
            case DirectionType.Right:                
                if (_startPosX.Value + EntityCar.Step + _drawningCarWidth < _pictureWidth)
                {
                    _startPosX += (int)EntityCar.Step;
                }
                return true;
            //Вниз
            case DirectionType.Down:                
                if (_startPosY.Value + EntityCar.Step + _drawingCarHeight < _pictureHeight)
                {
                    _startPosY += (int)EntityCar.Step;
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
    public virtual void DrawTransport(Graphics g)
    {
        if (EntityCar == null || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return;
        }

        Pen pen = new(Color.Black);
        Brush mainBrush = new SolidBrush(EntityCar.MainColor);

        // Границы машины (основной корпус)        
        g.FillRectangle(mainBrush, _startPosX.Value + 50, _startPosY.Value, 30, 30);
        g.DrawRectangle(pen, _startPosX.Value + 50, _startPosY.Value, 30, 30);
        
        g.FillRectangle(mainBrush, _startPosX.Value + 10, _startPosY.Value + 30, 70, 30);
        g.DrawRectangle(pen, _startPosX.Value + 10, _startPosY.Value + 30, 70, 30);

        g.FillRectangle(mainBrush, _startPosX.Value + 10, _startPosY.Value + 50, 70, 20);
        g.DrawRectangle(pen, _startPosX.Value + 10, _startPosY.Value + 50, 70, 20);
        
        g.FillRectangle(mainBrush, _startPosX.Value, _startPosY.Value + 39, 10, 30);
        g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value + 39, 10, 30);
    }

}

