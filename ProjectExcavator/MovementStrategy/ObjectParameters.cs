﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.MovementStrategy;
/// <summary>
/// Параметры-координаты объекта
/// </summary>
public class ObjectParameters
{
    /// <summary>
    /// Координата Х
    /// </summary>
    private readonly int _x;
    /// <summary>
    /// Координата У
    /// </summary>
    private readonly int _y;
    /// <summary>
    /// Ширина объекта
    /// </summary>
    private readonly int _width;
    /// <summary>
    /// Высота объекта
    /// </summary>
    private readonly int _height;
    /// <summary>
    /// Левая граница
    /// </summary>
    public int LeftBorder => _x;
    /// <summary>
    /// Верхняя граница
    /// </summary>
    public int TopBorder => _y;
    /// <summary>
    /// Правая граница
    /// </summary>
    public int RightBorder => _x + _width;
    /// <summary>
    /// Нижняя граница
    /// </summary>
    public int DownBorder => _y + _height;
    /// <summary>
    /// Середина объекта
    /// </summary>
    public int ObjectMiddleHorizontal => _x + _width / 2;
    /// <summary>
    /// Середина объекта
    /// </summary>
    public int ObjectMiddleVertical => _y + _height / 2;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    public ObjectParameters(int x, int y, int width, int height)
    {
        _x = x;
        _y = y;
        _width = width;
        _height = height;

    }
}

