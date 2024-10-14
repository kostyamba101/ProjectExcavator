using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectExcavator.Drawnings;
using ProjectExcavator.MovementStrategy;

namespace ProjectExcavator
{
    /// <summary>
    /// Форма работы с объектом "Экскаватор"
    /// </summary>
    public partial class FormExcavator : Form
    {
        /// <summary>
        /// Поле-объект для прорисовки объекта
        /// </summary>
        private DrawningCar? _drawningCar;

        private AbstractStrategy? _strategy;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public FormExcavator()
        {
            InitializeComponent();
            _strategy = null;
        }

        /// <summary>
        /// Метод прорисовки машины
        /// </summary>
        private void Draw()
        {
            if (_drawningCar == null)
            {
                return;
            }
            Bitmap bmp = new(pictureBoxExcavator.Width, pictureBoxExcavator.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawningCar.DrawTransport(gr);
            pictureBoxExcavator.Image = bmp;
        }
        /// <summary>
        /// Создание объекта класса-перемещения
        /// </summary>
        /// <param name="type">Тип объекта</param>
        private void CreateObject(string type)
        {
            Random random = new Random();
            switch (type)
            {
                case nameof(DrawningCar):
                    _drawningCar = new DrawningCar(random.Next(100, 300), random.Next(1000, 3000),
                        Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)));
                    break;
                case nameof(DrawningExcavator):
                    _drawningCar = new DrawningExcavator(random.Next(100, 300), random.Next(1000, 3000),
                        Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                        Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                        Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2))
                        );
                    break;
                default:
                    return;
            }
            _drawningCar.SetPictureSize(pictureBoxExcavator.Width, pictureBoxExcavator.Height);
            _drawningCar.SetPosition(random.Next(10, 100), random.Next(10, 100));
            _strategy = null;
            comboBoxStrategy.Enabled = true;
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать машину"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateCar_Click(object sender, EventArgs e) => CreateObject(nameof(DrawningCar));

        /// <summary>
        /// Обработка нажатия кнопки "Создать экскаватор"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateExcavator_Click(object sender, EventArgs e) => CreateObject(nameof(DrawningExcavator));

        /// <summary>
        /// Обработка кнопок движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (_drawningCar == null)
            {
                return;
            }
            string name = ((Button)sender)?.Name ?? string.Empty;
            bool result = false;
            switch (name)
            {
                case "buttonUp":
                    result = _drawningCar.MoveTransport(DirectionType.Up);
                    break;
                case "buttonDown":
                    result = _drawningCar.MoveTransport(DirectionType.Down);
                    break;
                case "buttonLeft":
                    result = _drawningCar.MoveTransport(DirectionType.Left);
                    break;
                case "buttonRight":
                    result = _drawningCar.MoveTransport(DirectionType.Right);
                    break;
            }
            if (result)
            {
                Draw();
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Шаг"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStrategyStep_Click(object sender, EventArgs e)
        {
            if (_drawningCar == null)
            {
                return;
            }
            if (comboBoxStrategy.Enabled)
            {
                _strategy = comboBoxStrategy.SelectedIndex switch
                {
                    0 => new MoveToCenter(),
                    1 => new MoveToBorder(),
                    _ => null
                }; 
                if(_strategy == null)
                {
                    return;
                }
                _strategy.SetData(new MoveableCar(_drawningCar), pictureBoxExcavator.Width, pictureBoxExcavator.Height);
            }
            if (_strategy == null)
            {
                return;

            }
            comboBoxStrategy.Enabled = false;
            _strategy.MakeStep();
            Draw();

            if (_strategy.GetStatus() == StrategyStatus.Finish)
            {
                comboBoxStrategy.Enabled = true;
                _strategy = null;
            }
        }
    }
}
