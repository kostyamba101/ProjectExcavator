using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.MovementStrategy;

public interface IMoveableObjects
{   
    /// <summary>
    /// Получение координаты объекта
    /// </summary>
    ObjectParameters? GetObjectParameters {  get; }

    /// <summary>
    /// Шаг объекта
    /// </summary>
    int GetStep {  get; }

    /// <summary>
    /// Попытка переместить объект в указанном направлении
    /// </summary>
    /// <param name="direction">Направление</param>
    /// <returns>true - объект перемещен, false - перемещение невозможно</returns>
    bool TryMoveObject(MovementDirection direction);
}
