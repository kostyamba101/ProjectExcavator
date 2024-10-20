using ProjectExcavator.Entities;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
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
    private readonly int _drawningCarWidth = 110;

    /// <summary>
    /// Высота прорисовки машины
    /// </summary>
    private readonly int _drawingCarHeight = 126;
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

    public DrawningCar(EntityCar car) : this()
    {
        EntityCar = new EntityCar(car.Speed, car.Weight, car.MainColor);
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

    public static GraphicsPath RoundedRect(Graphics g, Rectangle bounds, int radius)
    {
        int diameter = radius * 2;
        Size size = new Size(diameter, diameter);
        Rectangle arc = new Rectangle(bounds.Location, size);
        GraphicsPath path = new GraphicsPath();

        if (radius == 0)
        {
            path.AddRectangle(bounds);
            return path;
        }

        path.AddArc(arc, 180, 90);
        arc.X = bounds.Right - diameter;
        path.AddArc(arc, 270, 90);
        arc.Y = bounds.Bottom - diameter;
        path.AddArc(arc, 0, 90);
        arc.X = bounds.Left;
        path.AddArc(arc, 90, 90);

        g.FillPath(Brushes.Black, path);

        path.CloseFigure();
        return path;
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

        Brush brBlue = new SolidBrush(Color.LightBlue);
        Brush brGray = new SolidBrush(Color.Gray);
        Brush brRed = new SolidBrush(Color.Red);
        Brush brYellow = new SolidBrush(Color.Yellow);
        Brush brBlack = new SolidBrush(Color.Black);
        Brush bodycolor = new SolidBrush(EntityCar.MainColor);


        int bodyHeight = 90;
        int cabineHeight = 40;
        int pipeHeight = 35;
        int bucketWidth = 10;
        int pipeWidth = 7;

        int pipeOffsetX = 25;
        int cabineOffsetX = 50;

        int wheelsOffsetX = 20;
        int wheelsHeight = 40;

        //кузов
        g.DrawRectangle(pen, _startPosX.Value + bucketWidth, _startPosY.Value + cabineHeight, bodyHeight, bodyHeight - cabineHeight);
        g.FillRectangle(bodycolor, _startPosX.Value + bucketWidth, _startPosY.Value + cabineHeight, bodyHeight, bodyHeight - cabineHeight);

        //труба
        g.DrawRectangle(pen, _startPosX.Value + bucketWidth + pipeOffsetX, _startPosY.Value + cabineHeight - pipeHeight, pipeWidth, pipeHeight);
        g.FillRectangle(brBlack, _startPosX.Value + bucketWidth + pipeOffsetX, _startPosY.Value + cabineHeight - pipeHeight, pipeWidth, pipeHeight);

        //кабина
        g.DrawRectangle(pen, _startPosX.Value + bucketWidth + cabineOffsetX, _startPosY.Value, cabineHeight, cabineHeight);
        g.FillRectangle(brBlue, _startPosX.Value + bucketWidth + cabineOffsetX, _startPosY.Value, cabineHeight, cabineHeight);

        //трак
        g.DrawPath(pen, RoundedRect(g, new Rectangle(_startPosX.Value, _startPosY.Value + bodyHeight, wheelsOffsetX + bodyHeight, wheelsHeight), 15));

        Pen bPen = new(Color.Black);
        bPen.Width = 3;

        Rectangle wheel1 = new Rectangle(
            _startPosX.Value + bucketWidth + wheelsOffsetX - 25,
            _startPosY.Value + bodyHeight + wheelsHeight / 4,
            25, 25);

        Rectangle wheel2 = new Rectangle(
            _startPosX.Value + bucketWidth + (bodyHeight - wheelsOffsetX),
            _startPosY.Value + bodyHeight + wheelsHeight / 4,
            25, 25);

        g.DrawEllipse(bPen, wheel1);
        g.DrawEllipse(bPen, wheel2);

        g.FillEllipse(brBlue, wheel1);
        g.FillEllipse(brBlue, wheel2);

        //колеса
        g.DrawEllipse(bPen, _startPosX.Value + bucketWidth + wheelsOffsetX + 5, _startPosY.Value + bodyHeight + wheelsHeight / 2, 13, 13);
        g.DrawEllipse(bPen, _startPosX.Value + bucketWidth + wheelsOffsetX + 20, _startPosY.Value + bodyHeight + wheelsHeight / 2, 13, 13);
        g.DrawEllipse(bPen, _startPosX.Value + bucketWidth + wheelsOffsetX + 35, _startPosY.Value + bodyHeight + wheelsHeight / 2, 13, 13);
        g.FillEllipse(brRed, _startPosX.Value + bucketWidth + wheelsOffsetX + 5, _startPosY.Value + bodyHeight + wheelsHeight / 2, 13, 13);
        g.FillEllipse(brRed, _startPosX.Value + bucketWidth + wheelsOffsetX + 20, _startPosY.Value + bodyHeight + wheelsHeight / 2, 13, 13);
        g.FillEllipse(brRed, _startPosX.Value + bucketWidth + wheelsOffsetX + 35, _startPosY.Value + bodyHeight + wheelsHeight / 2, 13, 13);

        g.DrawEllipse(bPen, _startPosX.Value + bucketWidth + wheelsOffsetX + 13, _startPosY.Value + bodyHeight + wheelsHeight / 6, 9, 9);
        g.DrawEllipse(bPen, _startPosX.Value + bucketWidth + wheelsOffsetX + 28, _startPosY.Value + bodyHeight + wheelsHeight / 6, 9, 9);
        g.FillEllipse(brYellow, _startPosX.Value + bucketWidth + wheelsOffsetX + 13, _startPosY.Value + bodyHeight + wheelsHeight / 6, 9, 9);
        g.FillEllipse(brYellow, _startPosX.Value + bucketWidth + wheelsOffsetX + 28, _startPosY.Value + bodyHeight + wheelsHeight / 6, 9, 9);
    }

}

