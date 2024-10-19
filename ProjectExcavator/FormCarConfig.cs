using ProjectExcavator.Drawnings;
using ProjectExcavator.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectExcavator;
/// <summary>
/// Форма конфигурации объекта
/// </summary>
public partial class FormCarConfig : Form
{
    /// <summary>
    /// Объект прорисовка машины
    /// </summary>
    private DrawningCar? _car;

    /// <summary>
    /// Событие для передачи объекта
    /// </summary>
    private event CarDelegate? CarDelegate;
    /// <summary>
    /// Конструктор
    /// </summary>
    public FormCarConfig()
    {
        InitializeComponent();
        panelRed.MouseDown += Panel_MouseDown;
        panelGreen.MouseDown += Panel_MouseDown;
        panelBlue.MouseDown += Panel_MouseDown;
        panelYellow.MouseDown += Panel_MouseDown;
        panelWhite.MouseDown += Panel_MouseDown;
        panelGray.MouseDown += Panel_MouseDown;
        panelBlack.MouseDown += Panel_MouseDown;
        panelPurple.MouseDown += Panel_MouseDown;

        buttonCancel.Click += (sender, e) => Close();


    }
    /// <summary>
    /// Привязка внешнго метода к событию
    /// </summary>
    /// <param name="carDelegate"></param>
    public void AddEvent(CarDelegate carDelegate) => CarDelegate += carDelegate;

    /// <summary>
    /// Прорисовка объекта
    /// </summary>
    private void DrawObject()
    {
        Bitmap bmp = new(pictureBoxObject.Width, pictureBoxObject.Height);
        Graphics g = Graphics.FromImage(bmp);
        _car?.SetPictureSize(pictureBoxObject.Width, pictureBoxObject.Height);
        _car?.SetPosition(5, 5);
        _car?.DrawTransport(g);
        pictureBoxObject.Image = bmp;
    }
    /// <summary>
    /// Передаем информацию при нажатии Label
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LabelObject_MouseDown(object sender, MouseEventArgs e)
    {
        (sender as Label)?.DoDragDrop((sender as Label)?.Name ?? string.Empty, DragDropEffects.Move | DragDropEffects.Copy);
    }
    /// <summary>
    /// Проверка получаемой информации(её типа на соответствие требуемому)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PanelObject_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = e.Data?.GetDataPresent(DataFormats.Text) ?? false ? DragDropEffects.Copy : DragDropEffects.None;
    }
    /// <summary>
    /// Действие при приеме перетаскиваемой информации
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PanelObject_DragDrop(object sender, DragEventArgs e)
    {
        switch (e.Data?.GetData(DataFormats.Text)?.ToString())
        {
            case "labelSimpleObject":
                _car = new DrawningCar((int)numericUpDownSpeed.Value, (int)numericUpDownWeigth.Value, Color.White);
                break;
            case "labelModifiedObject":
                _car = new DrawningExcavator((int)numericUpDownSpeed.Value, (int)numericUpDownWeigth.Value, Color.White,
                    Color.Black, checkBoxHasBucket.Checked, checkBoxHasTube.Checked, checkBoxHasTracks.Checked);
                break;
        }

        DrawObject();
    }
    /// <summary>
    /// Передаем информацию при нажатии Panel
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Panel_MouseDown(object? sender, MouseEventArgs e)
    {
        (sender as Panel)?.DoDragDrop((sender as Panel)?.BackColor ?? Color.White, DragDropEffects.Move | DragDropEffects.Copy);
    }
    /// <summary>
    /// Проверка основного цвета
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LabelMainColor_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data?.GetDataPresent(typeof(Color)) ?? false)
        {
            e.Effect = DragDropEffects.Copy;
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }
    /// <summary>
    /// Действие при приеме перетаскиваемого цвета
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LabelMainColor_DragDrop(object sender, DragEventArgs e)
    {
        if (_car?.EntityCar != null && e?.Data?.GetData(typeof(Color)) is Color color)
        {
            _car.EntityCar.SetMainColor(color);
            DrawObject();
        }
    }
    /// <summary>
    /// Проверка дополнительного цвета
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LabelOptionalColor_DragEnter(object sender, DragEventArgs e)
    {
        if (_car is DrawningExcavator )
        {
            e.Effect = (e?.Data?.GetDataPresent(typeof(Color)) == true) ? DragDropEffects.Copy : DragDropEffects.None;
        }
        
    }
    /// <summary>
    /// Действие при приеме перетаскиваемого цвета
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LabelOptionalColor_DragDrop(object sender, DragEventArgs e)
    {
        if (_car?.EntityCar is EntityExcavator _excavator && e?.Data?.GetData(typeof(Color)) is Color color)
        {
            _excavator.SetOptionalColor(color);
        }
        DrawObject();
    }
    /// <summary>
    /// Передача объекта
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonAdd_Click(object sender, EventArgs e)
    {

        if (_car != null)
        {
            CarDelegate?.Invoke(_car);
            Close();
        }

    }
}
