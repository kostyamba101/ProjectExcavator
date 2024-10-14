using ProjectExcavator.Drawnings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.MovementStrategy;
/// <summary>
/// Класс-реализация IMoveableObjects c использованием DrawningCar
/// </summary>
public class MoveableCar : IMoveableObjects
{
    /// <summary>
    /// Поле-объект класса DrawningCar или его наследника
    /// </summary>
    private readonly DrawningCar? _car = null;
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="car"></param>
    public MoveableCar(DrawningCar car)
    {
        _car = car;
    }
    public ObjectParameters? GetObjectParameters
    {
        get
        {
            if (_car == null || _car.EntityCar == null || !_car.GetPosX.HasValue || !_car.GetPosY.HasValue)
            {
                return null;
            }
            return new ObjectParameters(_car.GetPosX.Value, _car.GetPosY.Value, _car.GetWidth, _car.GetHeight);
        }
    }

    public int GetStep => (int)(_car?.EntityCar?.Step ?? 0);

    public bool TryMoveObject(MovementDirection direction)
    {
        if (_car == null || _car.EntityCar == null)
        {
            return false;
        }
        return _car.MoveTransport(GetDirectionType(direction));
    }
    /// <summary>
    /// Конвертация из MovementDirection в DirectionType
    /// </summary>
    /// <param name="direction">MovementDirection</param>
    /// <returns>DirectionType</returns>
    private static DirectionType GetDirectionType(MovementDirection direction)
    {
        return direction switch
        {
            MovementDirection.Left => DirectionType.Left,
            MovementDirection.Right => DirectionType.Right,
            MovementDirection.Up => DirectionType.Up,
            MovementDirection.Down => DirectionType.Down,
            _ => DirectionType.Unknow,

        };
    }
}
