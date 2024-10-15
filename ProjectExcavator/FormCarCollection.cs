using ProjectExcavator.CollectionGenericObjects;
using ProjectExcavator.Drawnings;
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
/// Форма работы с компанией и её коллекцией
/// </summary>
public partial class FormCarCollection : Form
{
    /// <summary>
    /// Компания
    /// </summary>
    private AbstractCompany? _company = null;
    /// <summary>
    /// Конструктор
    /// </summary>
    public FormCarCollection()
    {
        InitializeComponent();
    }
    /// <summary>
    /// Выбор компании
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ComboBoxSelectorCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (comboBoxSelectorCompany.Text)
        {
            case "Хранилище":
                _company = new Garage(pictureBox.Width, pictureBox.Height, new ArrayGenericObjects<DrawningCar>());
                break;
        }
    }
    /// <summary>
    /// Добавление машины
    /// </summary>
    /// <param name="type">Тип объекта</param>
    private void CreateObject(string type)
    {

        if (_company == null)
        {
            return;
        }

        Random random = new Random();
        DrawningCar drawningCar;
        switch (type)
        {
            case nameof(DrawningCar):
                drawningCar = new DrawningCar(random.Next(100, 300), random.Next(1000, 3000), GetColor(random));
                break;
            case nameof(DrawningExcavator):
                drawningCar = new DrawningExcavator(random.Next(100, 300), random.Next(1000, 3000),
                    Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                    Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                    Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2))
                    );
                break;
            default:
                return;
        }

        if (_company + drawningCar)
        {
            MessageBox.Show("Объект добавлен");
            pictureBox.Image = _company.Show();
        }
        else
        {
            MessageBox.Show("Не удалось добавить объект");

        }
    }
    /// <summary>
    /// Добавление машины
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonAddCar_Click(object sender, EventArgs e) => CreateObject(nameof(DrawningCar));
    /// <summary>
    /// Добавление экскаватора
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonAddExcavator_Click(object sender, EventArgs e) => CreateObject(nameof(DrawningExcavator));

    /// <summary>
    /// Получение цвета
    /// </summary>
    /// <param name="random"></param>
    /// <returns></returns>
    private static Color GetColor(Random random)
    {
        Color color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        ColorDialog dialog = new();
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            color = dialog.Color;
        }
        return color;
    }
    /// <summary>
    /// Удаление объекта
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonRemoveCar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(maskedTextBoxPosition.Text) || _company == null)
        {
            return;
        }

        if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
            return;
        }

        int pos = Convert.ToInt32(maskedTextBoxPosition.Text);
        if (_company - pos)
        {
            MessageBox.Show("Объект удален");
            pictureBox.Image = _company.Show();
        }
        else
        {
            MessageBox.Show("Не удалось удалить объект");
        }
    }
    /// <summary>
    /// Получние случайной машины
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonGoToCheck_Click(object sender, EventArgs e)
    {
        if (_company == null)
        {
            return;
        }

        DrawningCar? car = null;
        int counter = 100;
        while (car == null)
        {
            car = _company.GetRandomObject();
            counter--;
            if (counter <= 0)
            {
                break;
            }
        }
        if (car == null)
        {
            return;
        }

        FormExcavator form = new()
        {
            SetCar = car,
        };
        form.ShowDialog();
    }
    /// <summary>
    /// Обновление формы
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonRefresh_Click(object sender, EventArgs e)
    {
        if (_company == null)
        {
            return;
        }
        pictureBox.Image = _company.Show();
    }
}
