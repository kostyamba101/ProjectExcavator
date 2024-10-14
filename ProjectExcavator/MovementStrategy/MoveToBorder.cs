using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.MovementStrategy;

public class MoveToBorder : AbstractStrategy
{
    protected override bool IsTargetDestination()
    {
        ObjectParameters? objectParams = GetObjectParameters;
        if (objectParams == null)
        {
            return false;
        }

        return objectParams.ObjectMiddleHorizontal - GetStep() <= 0 || objectParams.ObjectMiddleHorizontal + GetStep() >= FieldWidth ||
               objectParams.ObjectMiddleVertical - GetStep() <= 0 || objectParams.ObjectMiddleVertical + GetStep() >= FieldHeight;
    }

    protected override void MoveToTarget()
    {
        ObjectParameters? objectParams = GetObjectParameters;
        if (objectParams == null)
        {
            return;
        }

        // Двигаемся в сторону ближайшего края
        int diffXLeft = objectParams.ObjectMiddleHorizontal; // расстояние до левого края
        int diffXRight = FieldWidth - objectParams.ObjectMiddleHorizontal; // расстояние до правого края
        int diffYTop = objectParams.ObjectMiddleVertical; // расстояние до верхнего края
        int diffYBottom = FieldHeight - objectParams.ObjectMiddleVertical; // расстояние до нижнего края

        // Двигаемся по горизонтали к ближайшему краю
        if (diffXLeft < diffXRight)
        {
            if (diffXLeft > GetStep())
            {
                MoveLeft();
            }
        }
        else
        {
            if (diffXRight > GetStep())
            {
                MoveRight();
            }
        }

        // Двигаемся по вертикали к ближайшему краю
        if (diffYTop < diffYBottom)
        {
            if (diffYTop > GetStep())
            {
                MoveUp();
            }
        }
        else
        {
            if (diffYBottom > GetStep())
            {
                MoveDown();
            }
        }
    }
}


