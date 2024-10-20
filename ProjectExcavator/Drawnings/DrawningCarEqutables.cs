using ProjectExcavator.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.Drawnings;
/// <summary>
/// Реализация сравнения двух объектов класса-прорисовки
/// </summary>
public class DrawningCarEqutables : IEqualityComparer<DrawningCar?>
{
    public bool Equals(DrawningCar? x, DrawningCar? y)
    {
        if (x == null || x.EntityCar == null)
        {
            return false;
        }
        if (y == null || y.EntityCar == null)
        {
            return false;
        }
        if (x.GetType().Name != y.GetType().Name)
        {
            return false;
        }
        if (x.EntityCar.Speed != y.EntityCar.Speed)
        {
            return false;
        }
        if (x.EntityCar.Weight != y.EntityCar.Weight)
        {
            return false;
        }
        if (x.EntityCar.MainColor != y.EntityCar.MainColor)
        {
            return false;
        }
        if(x is DrawningExcavator && y is DrawningExcavator)
        {            
            EntityExcavator EntityX = (EntityExcavator)x.EntityCar;
            EntityExcavator EntityY = (EntityExcavator)y.EntityCar;

            if (EntityX.HasTracks != EntityY.HasTracks)
            {
                return false;
            }
            if (EntityX.HasTube != EntityY.HasTube)
            {
                return false;
            }
            if (EntityX.HasBucket != EntityY.HasBucket)
            {
                return false;
            }
        }
        return true;
    }

    public int GetHashCode([DisallowNull] DrawningCar? obj)
    {
        return obj.GetHashCode();
    }
}
