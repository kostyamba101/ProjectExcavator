﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.MovementStrategy;
/// <summary>
/// Статус выполнения операции перемещения
/// </summary>
public enum StrategyStatus
{
    /// <summary>
    /// Все готово к началу
    /// </summary>
    NotInit,
    /// <summary>
    /// Выполняется
    /// </summary>
    InProgress,
    /// <summary>
    /// Завершено
    /// </summary>
    Finish

}

