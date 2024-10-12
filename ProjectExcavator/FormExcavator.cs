using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private DrawningExcavator? _drawningExcavator;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public FormExcavator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод прорисовки машины
        /// </summary>
        private void Draw()
        {
            if (_drawningExcavator == null)
            {
                return;
            }
            Bitmap bmp = new(pictureBoxExcavator.Width, pictureBoxExcavator.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawningExcavator.DrawTransport(gr);
            pictureBoxExcavator.Image = bmp;
        }

        /// <summary>
        /// Обработка создания объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateExcavator_Click(object sender, EventArgs e)
        {
            Random random = new();
            _drawningExcavator = new DrawningExcavator();
            _drawningExcavator.Init(random.Next(100, 300), random.Next(100, 3000),
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                Convert.ToBoolean(random.Next(0, 2)),
                Convert.ToBoolean(random.Next(0, 2)),
                Convert.ToBoolean(random.Next(0, 2)));
            _drawningExcavator.SetPictureSize(pictureBoxExcavator.Width, pictureBoxExcavator.Height);
            _drawningExcavator.SetPosition(random.Next(10,100), random.Next(10,100));
            Draw();
        }
        /// <summary>
        /// Обработка кнопок движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (_drawningExcavator == null)
            {
                return;
            }
            string name = ((Button)sender)?.Name ?? string.Empty;
            bool result = false;
            switch (name)
            {
                case "buttonUp":
                    result = _drawningExcavator.MoveTransport(DirectionType.Up);
                    break;
                case "buttonDown":
                    result = _drawningExcavator.MoveTransport(DirectionType.Down);
                    break;
                case "buttonLeft":
                    result = _drawningExcavator.MoveTransport(DirectionType.Left);
                    break;
                case "buttonRight":
                    result = _drawningExcavator.MoveTransport(DirectionType.Right);
                    break;
            }
            if (result)
            {
                Draw();
            }
        }
    }
}
