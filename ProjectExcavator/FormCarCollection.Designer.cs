namespace ProjectExcavator
{
    partial class FormCarCollection
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
            groupBoxTools = new GroupBox();
            buttonRefresh = new Button();
            buttonGoToCheck = new Button();
            buttonRemoveCar = new Button();
            maskedTextBoxPosition = new MaskedTextBox();
            buttonAddExcavator = new Button();
            buttonAddCar = new Button();
            comboBoxSelectorCompany = new ComboBox();
            pictureBox = new PictureBox();
            groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTools
            // 
            groupBoxTools.Controls.Add(buttonRefresh);
            groupBoxTools.Controls.Add(buttonGoToCheck);
            groupBoxTools.Controls.Add(buttonRemoveCar);
            groupBoxTools.Controls.Add(maskedTextBoxPosition);
            groupBoxTools.Controls.Add(buttonAddExcavator);
            groupBoxTools.Controls.Add(buttonAddCar);
            groupBoxTools.Controls.Add(comboBoxSelectorCompany);
            groupBoxTools.Dock = DockStyle.Right;
            groupBoxTools.Location = new Point(840, 0);
            groupBoxTools.Name = "groupBoxTools";
            groupBoxTools.Size = new Size(250, 512);
            groupBoxTools.TabIndex = 0;
            groupBoxTools.TabStop = false;
            groupBoxTools.Text = "Инструменты";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRefresh.Location = new Point(6, 439);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(238, 47);
            buttonRefresh.TabIndex = 7;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // buttonGoToCheck
            // 
            buttonGoToCheck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonGoToCheck.Location = new Point(6, 365);
            buttonGoToCheck.Name = "buttonGoToCheck";
            buttonGoToCheck.Size = new Size(238, 47);
            buttonGoToCheck.TabIndex = 6;
            buttonGoToCheck.Text = "Отправить на полигон";
            buttonGoToCheck.UseVisualStyleBackColor = true;
            buttonGoToCheck.Click += ButtonGoToCheck_Click;
            // 
            // buttonRemoveCar
            // 
            buttonRemoveCar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRemoveCar.Location = new Point(6, 285);
            buttonRemoveCar.Name = "buttonRemoveCar";
            buttonRemoveCar.Size = new Size(238, 47);
            buttonRemoveCar.TabIndex = 5;
            buttonRemoveCar.Text = "Удалить машину";
            buttonRemoveCar.UseVisualStyleBackColor = true;
            buttonRemoveCar.Click += ButtonRemoveCar_Click;
            // 
            // maskedTextBoxPosition
            // 
            maskedTextBoxPosition.Location = new Point(6, 252);
            maskedTextBoxPosition.Mask = "00";
            maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            maskedTextBoxPosition.Size = new Size(238, 27);
            maskedTextBoxPosition.TabIndex = 3;
            maskedTextBoxPosition.ValidatingType = typeof(int);
            // 
            // buttonAddExcavator
            // 
            buttonAddExcavator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddExcavator.Location = new Point(6, 147);
            buttonAddExcavator.Name = "buttonAddExcavator";
            buttonAddExcavator.Size = new Size(238, 47);
            buttonAddExcavator.TabIndex = 2;
            buttonAddExcavator.Text = "Добавление экскаватора";
            buttonAddExcavator.UseVisualStyleBackColor = true;
            buttonAddExcavator.Click += ButtonAddExcavator_Click;
            // 
            // buttonAddCar
            // 
            buttonAddCar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddCar.Location = new Point(6, 94);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(238, 47);
            buttonAddCar.TabIndex = 1;
            buttonAddCar.Text = "Добавление машины";
            buttonAddCar.UseVisualStyleBackColor = true;
            buttonAddCar.Click += ButtonAddCar_Click;
            // 
            // comboBoxSelectorCompany
            // 
            comboBoxSelectorCompany.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSelectorCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectorCompany.FormattingEnabled = true;
            comboBoxSelectorCompany.Items.AddRange(new object[] { "Хранилище" });
            comboBoxSelectorCompany.Location = new Point(6, 35);
            comboBoxSelectorCompany.Name = "comboBoxSelectorCompany";
            comboBoxSelectorCompany.Size = new Size(238, 28);
            comboBoxSelectorCompany.TabIndex = 0;
            comboBoxSelectorCompany.SelectedIndexChanged += ComboBoxSelectorCompany_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(840, 512);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // FormCarCollection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 512);
            Controls.Add(pictureBox);
            Controls.Add(groupBoxTools);
            Name = "FormCarCollection";
            Text = "Коллекция машин";
            groupBoxTools.ResumeLayout(false);
            groupBoxTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTools;
        private ComboBox comboBoxSelectorCompany;
        private Button buttonAddCar;
        private MaskedTextBox maskedTextBoxPosition;
        private PictureBox pictureBox;
        private Button buttonGoToCheck;
        private Button buttonRemoveCar;
        private Button buttonAddExcavator;
        private Button buttonRefresh;
    }
}