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

    public DrawningExcavator(EntityExcavator excavator) : base(125, 85)
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
        Brush mainBrush = new SolidBrush(excavator.MainColor);
        Brush optionalBrush = new SolidBrush(excavator.OptionalColor);
        Brush brBlack = new SolidBrush(Color.Black);

        _startPosX += 40;
        _startPosY += 20;
        base.DrawTransport(g);
        _startPosX -= 40;
        _startPosY -= 20;


        // труба            
        if (excavator.HasTube)
        {
            g.FillRectangle(mainBrush, _startPosX.Value + 70, _startPosY.Value + 30, 10, 20);
            g.DrawRectangle(pen, _startPosX.Value + 70, _startPosY.Value + 30, 10, 20);
        }
        // ковш
        if (excavator.HasBucket)
        {
            g.FillRectangle(optionalBrush, _startPosX.Value + 50, _startPosY.Value + 19, 10, 30);
            g.DrawRectangle(pen, _startPosX.Value + 50, _startPosY.Value + 19, 10, 30);
            g.FillRectangle(optionalBrush, _startPosX.Value + 10, _startPosY.Value + 19, 50, 10);
            g.DrawRectangle(pen, _startPosX.Value + 10, _startPosY.Value + 19, 50, 10);
            g.FillRectangle(optionalBrush, _startPosX.Value + 10, _startPosY.Value + 19, 10, 40);
            g.DrawRectangle(pen, _startPosX.Value + 10, _startPosY.Value + 19, 10, 40);
            g.FillRectangle(mainBrush, _startPosX.Value + 20, _startPosY.Value + 50, 10, 10);
            g.DrawRectangle(pen, _startPosX.Value + 20, _startPosY.Value + 50, 10, 10);
        }

        // гусеницы            
        if (excavator.HasTracks)
        {
            g.FillEllipse(brBlack, _startPosX.Value + 45, _startPosY.Value + 75, 20, 20);
            g.DrawEllipse(pen, _startPosX.Value + 45, _startPosY.Value + 75, 20, 20);

            g.FillEllipse(brBlack, _startPosX.Value + 65, _startPosY.Value + 75, 20, 20);
            g.DrawEllipse(pen, _startPosX.Value + 65, _startPosY.Value + 75, 20, 20);

            g.FillEllipse(brBlack, _startPosX.Value + 85, _startPosY.Value + 75, 20, 20);
            g.DrawEllipse(pen, _startPosX.Value + 85, _startPosY.Value + 75, 20, 20);

            g.FillEllipse(brBlack, _startPosX.Value + 105, _startPosY.Value + 75, 20, 20);
            g.DrawEllipse(pen, _startPosX.Value + 105, _startPosY.Value + 75, 20, 20);

        }


    }
}
