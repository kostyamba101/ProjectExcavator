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
        /// Получение объекта
        /// </summary>
        public DrawningCar SetCar
        {
            set
            {
                _drawningCar = value;
                _drawningCar.SetPictureSize(pictureBoxExcavator.Width, pictureBoxExcavator.Height);
                comboBoxStrategy.Enabled = true;
                _strategy = null;
                Draw();
            }
        }

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
