﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.Drawnings;
/// <summary>
/// Сравнение по цвету, скорости весу
/// </summary>
public class DrawningCarCompareByColor : IComparer<DrawningCar?>
{
    public int Compare(DrawningCar? x, DrawningCar? y)
    {
        if (x == null || x.EntityCar == null)
        {
            return 1;
        }

        if (y == null || y.EntityCar == null)
        {
            return -1;
        }
        var mainColorCompare = x.EntityCar.MainColor.Name.CompareTo(y.EntityCar.MainColor.Name);
        if (mainColorCompare != 0)
        {
            return mainColorCompare;
        }
        var speedCompare = x.EntityCar.Speed.CompareTo(y.EntityCar.Speed);
        if (speedCompare != 0)
        {
            return speedCompare;
        }
        return x.EntityCar.Weight.CompareTo(y.EntityCar.Weight);
    }
}