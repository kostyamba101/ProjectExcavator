using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.MovementStrategy;

public class MoveToCenter : AbstractStrategy
{
    protected override bool IsTargetDestination()
    {
        ObjectParameters? objectParam = GetObjectParameters;
        if(objectParam == null)
        {
            return false;
        }
        return objectParam.ObjectMiddleHorizontal - GetStep() <= FieldWidth / 2 && objectParam.ObjectMiddleHorizontal + GetStep() >= FieldWidth / 2 &&
                   objectParam.ObjectMiddleVertical - GetStep() <= FieldHeight / 2 && objectParam.ObjectMiddleVertical + GetStep() >= FieldHeight / 2;

    }

    protected override void MoveToTarget()
    {
        ObjectParameters? objectParams = GetObjectParameters;
        if(objectParams == null)
        {
            return;
        }

        int diffX = objectParams.ObjectMiddleHorizontal - FieldWidth / 2;
        if (Math.Abs(diffX) > GetStep())
        {
            if(diffX > 0)
            {
                MoveLeft();
            }
            else
            {
                MoveRight();
            }
        }

        int diffY = objectParams.ObjectMiddleVertical - FieldHeight / 2;
        if(Math.Abs(diffY) > GetStep())
        {
            if (diffY > 0)
            {
                MoveUp();
            }
            else
            {
                MoveDown();
            }
        }
    }
}
