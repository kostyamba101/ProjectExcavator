namespace ProjectExcavator
{
    partial class FormCarConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxConfig = new GroupBox();
            groupBoxColors = new GroupBox();
            panelPurple = new Panel();
            panelYellow = new Panel();
            panelBlack = new Panel();
            panelBlue = new Panel();
            panelGray = new Panel();
            panelGreen = new Panel();
            panelWhite = new Panel();
            panelRed = new Panel();
            checkBoxHasTube = new CheckBox();
            checkBoxHasTracks = new CheckBox();
            checkBoxHasBucket = new CheckBox();
            numericUpDownWeigth = new NumericUpDown();
            labelWeigth = new Label();
            numericUpDownSpeed = new NumericUpDown();
            labelSpeed = new Label();
            labelModifiedObject = new Label();
            labelSimpleObject = new Label();
            pictureBoxObject = new PictureBox();
            buttonAdd = new Button();
            buttonCancel = new Button();
            panelObject = new Panel();
            labelOptionalColor = new Label();
            labelMainColor = new Label();
            groupBoxConfig.SuspendLayout();
            groupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeigth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObject).BeginInit();
            panelObject.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxConfig
            // 
            groupBoxConfig.Controls.Add(groupBoxColors);
            groupBoxConfig.Controls.Add(checkBoxHasTube);
            groupBoxConfig.Controls.Add(checkBoxHasTracks);
            groupBoxConfig.Controls.Add(checkBoxHasBucket);
            groupBoxConfig.Controls.Add(numericUpDownWeigth);
            groupBoxConfig.Controls.Add(labelWeigth);
            groupBoxConfig.Controls.Add(numericUpDownSpeed);
            groupBoxConfig.Controls.Add(labelSpeed);
            groupBoxConfig.Controls.Add(labelModifiedObject);
            groupBoxConfig.Controls.Add(labelSimpleObject);
            groupBoxConfig.Dock = DockStyle.Left;
            groupBoxConfig.Location = new Point(0, 0);
            groupBoxConfig.Name = "groupBoxConfig";
            groupBoxConfig.Size = new Size(539, 310);
            groupBoxConfig.TabIndex = 0;
            groupBoxConfig.TabStop = false;
            groupBoxConfig.Text = "Параметры";
            // 
            // groupBoxColors
            // 
            groupBoxColors.Controls.Add(panelPurple);
            groupBoxColors.Controls.Add(panelYellow);
            groupBoxColors.Controls.Add(panelBlack);
            groupBoxColors.Controls.Add(panelBlue);
            groupBoxColors.Controls.Add(panelGray);
            groupBoxColors.Controls.Add(panelGreen);
            groupBoxColors.Controls.Add(panelWhite);
            groupBoxColors.Controls.Add(panelRed);
            groupBoxColors.Location = new Point(273, 18);
            groupBoxColors.Name = "groupBoxColors";
            groupBoxColors.Size = new Size(213, 125);
            groupBoxColors.TabIndex = 9;
            groupBoxColors.TabStop = false;
            groupBoxColors.Text = "Цвета";
            // 
            // panelPurple
            // 
            panelPurple.BackColor = Color.Purple;
            panelPurple.Location = new Point(163, 76);
            panelPurple.Name = "panelPurple";
            panelPurple.Size = new Size(36, 34);
            panelPurple.TabIndex = 3;
            // 
            // panelYellow
            // 
            panelYellow.BackColor = Color.Yellow;
            panelYellow.Location = new Point(163, 26);
            panelYellow.Name = "panelYellow";
            panelYellow.Size = new Size(36, 34);
            panelYellow.TabIndex = 1;
            // 
            // panelBlack
            // 
            panelBlack.BackColor = Color.Black;
            panelBlack.Location = new Point(112, 76);
            panelBlack.Name = "panelBlack";
            panelBlack.Size = new Size(36, 34);
            panelBlack.TabIndex = 4;
            // 
            // panelBlue
            // 
            panelBlue.BackColor = Color.Blue;
            panelBlue.Location = new Point(112, 26);
            panelBlue.Name = "panelBlue";
            panelBlue.Size = new Size(36, 34);
            panelBlue.TabIndex = 1;
            // 
            // panelGray
            // 
            panelGray.BackColor = Color.Gray;
            panelGray.Location = new Point(58, 76);
            panelGray.Name = "panelGray";
            panelGray.Size = new Size(36, 34);
            panelGray.TabIndex = 5;
            // 
            // panelGreen
            // 
            panelGreen.BackColor = Color.Green;
            panelGreen.Location = new Point(58, 26);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(36, 34);
            panelGreen.TabIndex = 1;
            // 
            // panelWhite
            // 
            panelWhite.BackColor = Color.White;
            panelWhite.Location = new Point(6, 76);
            panelWhite.Name = "panelWhite";
            panelWhite.Size = new Size(36, 34);
            panelWhite.TabIndex = 2;
            // 
            // panelRed
            // 
            panelRed.BackColor = Color.Red;
            panelRed.Location = new Point(6, 26);
            panelRed.Name = "panelRed";
            panelRed.Size = new Size(36, 34);
            panelRed.TabIndex = 0;
            // 
            // checkBoxHasTube
            // 
            checkBoxHasTube.AutoSize = true;
            checkBoxHasTube.Location = new Point(12, 149);
            checkBoxHasTube.Name = "checkBoxHasTube";
            checkBoxHasTube.Size = new Size(72, 24);
            checkBoxHasTube.TabIndex = 8;
            checkBoxHasTube.Text = "Труба";
            checkBoxHasTube.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasTracks
            // 
            checkBoxHasTracks.AutoSize = true;
            checkBoxHasTracks.Location = new Point(12, 179);
            checkBoxHasTracks.Name = "checkBoxHasTracks";
            checkBoxHasTracks.Size = new Size(98, 24);
            checkBoxHasTracks.TabIndex = 7;
            checkBoxHasTracks.Text = "Гусеницы";
            checkBoxHasTracks.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasBucket
            // 
            checkBoxHasBucket.AutoSize = true;
            checkBoxHasBucket.Location = new Point(12, 119);
            checkBoxHasBucket.Name = "checkBoxHasBucket";
            checkBoxHasBucket.Size = new Size(69, 24);
            checkBoxHasBucket.TabIndex = 6;
            checkBoxHasBucket.Text = "Ковш";
            checkBoxHasBucket.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeigth
            // 
            numericUpDownWeigth.Location = new Point(91, 69);
            numericUpDownWeigth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownWeigth.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownWeigth.Name = "numericUpDownWeigth";
            numericUpDownWeigth.Size = new Size(150, 27);
            numericUpDownWeigth.TabIndex = 5;
            numericUpDownWeigth.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelWeigth
            // 
            labelWeigth.AutoSize = true;
            labelWeigth.Location = new Point(12, 71);
            labelWeigth.Name = "labelWeigth";
            labelWeigth.Size = new Size(33, 20);
            labelWeigth.TabIndex = 4;
            labelWeigth.Text = "Вес";
            // 
            // numericUpDownSpeed
            // 
            numericUpDownSpeed.Location = new Point(91, 32);
            numericUpDownSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownSpeed.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownSpeed.Name = "numericUpDownSpeed";
            numericUpDownSpeed.Size = new Size(150, 27);
            numericUpDownSpeed.TabIndex = 3;
            numericUpDownSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(12, 32);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(73, 20);
            labelSpeed.TabIndex = 2;
            labelSpeed.Text = "Скорость";
            // 
            // labelModifiedObject
            // 
            labelModifiedObject.BorderStyle = BorderStyle.FixedSingle;
            labelModifiedObject.Location = new Point(385, 171);
            labelModifiedObject.Name = "labelModifiedObject";
            labelModifiedObject.Size = new Size(124, 32);
            labelModifiedObject.TabIndex = 1;
            labelModifiedObject.Text = "Продвинутый";
            labelModifiedObject.TextAlign = ContentAlignment.MiddleCenter;
            labelModifiedObject.MouseDown += LabelObject_MouseDown;
            // 
            // labelSimpleObject
            // 
            labelSimpleObject.BorderStyle = BorderStyle.FixedSingle;
            labelSimpleObject.Location = new Point(243, 171);
            labelSimpleObject.Name = "labelSimpleObject";
            labelSimpleObject.Size = new Size(124, 32);
            labelSimpleObject.TabIndex = 0;
            labelSimpleObject.Text = "Простой";
            labelSimpleObject.TextAlign = ContentAlignment.MiddleCenter;
            labelSimpleObject.MouseDown += LabelObject_MouseDown;
            // 
            // pictureBoxObject
            // 
            pictureBoxObject.Location = new Point(24, 57);
            pictureBoxObject.Name = "pictureBoxObject";
            pictureBoxObject.Size = new Size(227, 178);
            pictureBoxObject.TabIndex = 1;
            pictureBoxObject.TabStop = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(561, 244);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(682, 244);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelObject
            // 
            panelObject.AllowDrop = true;
            panelObject.Controls.Add(labelOptionalColor);
            panelObject.Controls.Add(labelMainColor);
            panelObject.Controls.Add(pictureBoxObject);
            panelObject.Location = new Point(537, 0);
            panelObject.Name = "panelObject";
            panelObject.Size = new Size(263, 238);
            panelObject.TabIndex = 4;
            panelObject.DragDrop += PanelObject_DragDrop;
            panelObject.DragEnter += PanelObject_DragEnter;
            // 
            // labelOptionalColor
            // 
            labelOptionalColor.AllowDrop = true;
            labelOptionalColor.BorderStyle = BorderStyle.FixedSingle;
            labelOptionalColor.Location = new Point(145, 18);
            labelOptionalColor.Name = "labelOptionalColor";
            labelOptionalColor.Size = new Size(106, 32);
            labelOptionalColor.TabIndex = 11;
            labelOptionalColor.Text = "Доп цвет";
            labelOptionalColor.TextAlign = ContentAlignment.MiddleCenter;
            labelOptionalColor.DragDrop += LabelOptionalColor_DragDrop;
            labelOptionalColor.DragEnter += LabelOptionalColor_DragEnter;
            // 
            // labelMainColor
            // 
            labelMainColor.AllowDrop = true;
            labelMainColor.BorderStyle = BorderStyle.FixedSingle;
            labelMainColor.Location = new Point(24, 18);
            labelMainColor.Name = "labelMainColor";
            labelMainColor.Size = new Size(108, 32);
            labelMainColor.TabIndex = 10;
            labelMainColor.Text = "Цвет";
            labelMainColor.TextAlign = ContentAlignment.MiddleCenter;
            labelMainColor.DragDrop += LabelMainColor_DragDrop;
            labelMainColor.DragEnter += LabelMainColor_DragEnter;
            // 
            // FormCarConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 310);
            Controls.Add(panelObject);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxConfig);
            Name = "FormCarConfig";
            Text = "Создание объекта";
            groupBoxConfig.ResumeLayout(false);
            groupBoxConfig.PerformLayout();
            groupBoxColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeigth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObject).EndInit();
            panelObject.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConfig;
        private NumericUpDown numericUpDownSpeed;
        private Label labelSpeed;
        private Label labelModifiedObject;
        private Label labelSimpleObject;
        private NumericUpDown numericUpDownWeigth;
        private Label labelWeigth;
        private CheckBox checkBoxHasBucket;
        private CheckBox checkBoxHasTube;
        private CheckBox checkBoxHasTracks;
        private GroupBox groupBoxColors;
        private Panel panelPurple;
        private Panel panelYellow;
        private Panel panelBlack;
        private Panel panelBlue;
        private Panel panelGray;
        private Panel panelGreen;
        private Panel panelWhite;
        private Panel panelRed;
        private PictureBox pictureBoxObject;
        private Button buttonAdd;
        private Button buttonCancel;
        private Panel panelObject;
        private Label labelOptionalColor;
        private Label labelMainColor;
    }
}