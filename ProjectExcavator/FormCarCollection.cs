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
    private readonly StorageCollection<DrawningCar> _storageCollection;
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
        _storageCollection = new();
    }
    /// <summary>
    /// Выбор компании
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ComboBoxSelectorCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        panelCompanyTools.Enabled = false;
    }

    /// <summary>
    /// Добавление машины
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonAddCar_Click(object sender, EventArgs e)
    {
        FormCarConfig form = new();
        form.AddEvent(SetCar);
        form.Show();
    }

    /// <summary>
    /// Добавление машины в коллекцию
    /// </summary>
    /// <param name="car"></param>
    private void SetCar(DrawningCar car)
    {
        if (_company == null || car == null)
        {
            return;
        }

        if (_company + car)
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
    /// <summary>
    /// Добавление коллекции
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonCollectionAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxCollectionName.Text) || (!radioButtonList.Checked && !radioButtonMassive.Checked))
        {
            MessageBox.Show("Не все данные заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        CollectionType collectionType = CollectionType.None;
        if (radioButtonMassive.Checked)
        {
            collectionType = CollectionType.Massive;
        }
        else if (radioButtonList.Checked)
        {
            collectionType = CollectionType.List;
        }

        _storageCollection.AddCollection(textBoxCollectionName.Text, collectionType);
        RefreshListBoxItems();

    }
    /// <summary>
    /// Удаление коллекции
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonCollectionDel_Click(object sender, EventArgs e)
    {

        if (listBoxCollection.SelectedIndex < 0 || listBoxCollection.SelectedItem == null)
        {
            MessageBox.Show("Коллекция не выбрана");
            return;
        }
        //спросить пользоваля через мессежбокс
        if (MessageBox.Show("Удалить коллекцию?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
            return;
        }
        //удалить и обновить листбокс
        _storageCollection.DelCollection(listBoxCollection.SelectedItem.ToString());
        RefreshListBoxItems();
    }
    /// <summary>
    /// Обновление списка в listBoxCollection
    /// </summary>
    private void RefreshListBoxItems()
    {
        listBoxCollection.Items.Clear();
        for (int i = 0; i < _storageCollection.Keys?.Count; ++i)
        {
            string? colName = _storageCollection.Keys?[i];
            if (!string.IsNullOrEmpty(colName))
            {
                listBoxCollection.Items.Add(colName);
            }
        }
    }

    /// <summary>
    /// Создание компании
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonCreateCompany_Click(object sender, EventArgs e)
    {
        if (listBoxCollection.SelectedIndex < 0 || listBoxCollection.SelectedItem == null)
        {
            MessageBox.Show("Коллекция не выбрана");
            return;
        }
        ICollectionGenericObjects<DrawningCar>? collection = _storageCollection[listBoxCollection.SelectedItem.ToString() ?? string.Empty];
        if (collection == null)
        {
            MessageBox.Show("Коллекция не проиницилизирована");
            return;
        }

        switch (comboBoxSelectorCompany.Text)
        {
            case "Хранилище":
                _company = new Garage(pictureBox.Width, pictureBox.Height, collection);
                break;
        }

        panelCompanyTools.Enabled = true;
        RefreshListBoxItems();
    }
    /// <summary>
    /// Обработка нажатия "Сохранения"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            if (_storageCollection.SaveData(saveFileDialog.FileName))
            {
                MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    /// <summary>
    /// Обработка нажатия "Загрузка"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            if (_storageCollection.LoadData(openFileDialog.FileName))
            {
                MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshListBoxItems();
            }
            else
            {
                MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
