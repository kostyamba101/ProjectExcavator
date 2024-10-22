using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectExcavator.Entities;

namespace ProjectExcavator.Drawnings;

/// <summary>
/// Класс, отвечающий за прорисовку и перемещение объекта-сущности
/// </summary>
public class DrawningExcavator : DrawningCar
{
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="speed">скорость</param>
    /// <param name="weight">вес</param>
    /// <param name="mainColor">главный цвет</param>
    /// <param name="optionalColor">дополнительный цвет</param>
    /// <param name="hasBusket">ковш</param>
    /// <param name="hasTube">кабина</param>
    /// <param name="hasTracks">гусеницы</param>
    public DrawningExcavator(int speed, double weight, Color mainColor, Color optionalColor, bool hasBusket, bool hasTube, bool hasTracks) : base(125, 85)
    {
        EntityCar = new EntityExcavator(speed, weight, mainColor, optionalColor, hasBusket, hasTube, hasTracks);
    }

    public DrawningExcavator(EntityExcavator excavator) : base(150, 126)
    {
        EntityCar = new EntityExcavator(excavator.Speed, excavator.Weight, excavator.MainColor, 
            excavator.OptionalColor, excavator.HasBucket, excavator.HasTube, excavator.HasTracks);
    }

    /// <summary>
    /// Прорисовка объекта
    /// </summary>
    /// <param name="g"></param>
    public override void DrawTransport(Graphics g)
    {
        if (EntityCar == null || EntityCar is not EntityExcavator excavator || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return;
        }

        Pen pen = new(Color.Black);
        Brush optionalBrush = new SolidBrush(excavator.OptionalColor);
        Brush brBlue = new SolidBrush(Color.LightBlue);
        Brush brGray = new SolidBrush(Color.Gray);
        Brush brRed = new SolidBrush(Color.Red);
        Brush brYellow = new SolidBrush(Color.Yellow);
        Brush brBlack = new SolidBrush(Color.Black);

        int bodyHeight = 90;
        int cabineHeight = 40;
        int bucketWidth = 30;
        int wheelsHeight = 40;

        int pipeHeight = 35;
        int pipeWidth = 7;
        int pipeOffsetX = 25;

        Pen bPen = new(Color.Black);
        bPen.Width = 3;

        _startPosX += 20;
        base.DrawTransport(g);
        _startPosX -= 20;


        // ковш
        if (excavator.HasBucket)
        {

            PointF p1 = new Point(_startPosX.Value + bucketWidth, _startPosY.Value + cabineHeight);
            PointF p2 = new Point(_startPosX.Value, _startPosY.Value + cabineHeight);
            PointF p3 = new Point(_startPosX.Value + bucketWidth, _startPosY.Value + cabineHeight + bodyHeight / 2);

            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p2, p3);
            g.DrawLine(pen, p3, p1);

            g.FillPolygon(optionalBrush, [p1, p2, p3]);

        }
        // опоры
        if (excavator.HasTracks)
        {
            g.DrawLine(bPen,
                _startPosX.Value + bucketWidth + bodyHeight, _startPosY.Value + cabineHeight + 10,
                _startPosX.Value + bucketWidth + bodyHeight + 15, _startPosY.Value + cabineHeight + 10);
            g.DrawLine(bPen,
                _startPosX.Value + bucketWidth + bodyHeight + 15, _startPosY.Value + cabineHeight + 10,
                _startPosX.Value + bucketWidth + bodyHeight + 15, _startPosY.Value + bodyHeight + wheelsHeight);
            g.DrawLine(bPen,
                _startPosX.Value + bucketWidth + bodyHeight + 15, _startPosY.Value + bodyHeight + wheelsHeight,
                _startPosX.Value + bucketWidth + bodyHeight + 30, _startPosY.Value + bodyHeight + wheelsHeight);
        }

        if (excavator.HasTube)
        {
            //труба
            g.DrawRectangle(pen, _startPosX.Value + bucketWidth + pipeOffsetX, _startPosY.Value + cabineHeight - pipeHeight, pipeWidth, pipeHeight);
            g.FillRectangle(optionalBrush, _startPosX.Value + bucketWidth + pipeOffsetX, _startPosY.Value + cabineHeight - pipeHeight, pipeWidth, pipeHeight);
        }
    }
}
