using ProjectExcavator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.Drawnings;

public static class ExtentionDrawningCar
{
    private static readonly string _separatorForObject = ":";

    public static DrawningCar? CreateDrawningCar(this string info)
    {
        string[] strs = info.Split(_separatorForObject);
        EntityCar? car = EntityExcavator.CreateEntityExcavator(strs);
        if (car != null)
        {
            return new DrawningCar(car);
        }

        car = EntityCar.CreateEntityCar(strs);
        if (car != null)
        {
            return new DrawningCar(car);
        }

        return null;

    }
    /// <summary>
    /// Получение данных для сохранения в файл
    /// </summary>
    /// <param name="drawningCar"></param>
    /// <returns></returns>
    public static string GetDataForSave(this DrawningCar drawningCar)
    {
        string[]? array = drawningCar?.EntityCar?.GetStringRepresentation();

        if (array == null)
        {
            return string.Empty;
        }

        return string.Join(_separatorForObject, array);
    }
}
