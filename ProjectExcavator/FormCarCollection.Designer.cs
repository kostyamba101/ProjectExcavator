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
            panelCompanyTools = new Panel();
            buttonAddCar = new Button();
            buttonRefresh = new Button();
            maskedTextBoxPosition = new MaskedTextBox();
            buttonGoToCheck = new Button();
            buttonRemoveCar = new Button();
            panelStorage = new Panel();
            buttonCreateCompany = new Button();
            buttonCollectionDel = new Button();
            listBoxCollection = new ListBox();
            buttonCollectionAdd = new Button();
            radioButtonList = new RadioButton();
            radioButtonMassive = new RadioButton();
            textBoxCollectionName = new TextBox();
            labelCollectionName = new Label();
            comboBoxSelectorCompany = new ComboBox();
            pictureBox = new PictureBox();
            groupBoxTools.SuspendLayout();
            panelCompanyTools.SuspendLayout();
            panelStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTools
            // 
            groupBoxTools.Controls.Add(panelCompanyTools);
            groupBoxTools.Controls.Add(panelStorage);
            groupBoxTools.Dock = DockStyle.Right;
            groupBoxTools.Location = new Point(840, 0);
            groupBoxTools.Name = "groupBoxTools";
            groupBoxTools.Size = new Size(250, 723);
            groupBoxTools.TabIndex = 0;
            groupBoxTools.TabStop = false;
            groupBoxTools.Text = "Инструменты";
            // 
            // panelCompanyTools
            // 
            panelCompanyTools.Controls.Add(buttonAddCar);
            panelCompanyTools.Controls.Add(buttonRefresh);
            panelCompanyTools.Controls.Add(maskedTextBoxPosition);
            panelCompanyTools.Controls.Add(buttonGoToCheck);
            panelCompanyTools.Controls.Add(buttonRemoveCar);
            panelCompanyTools.Enabled = false;
            panelCompanyTools.Location = new Point(0, 372);
            panelCompanyTools.Name = "panelCompanyTools";
            panelCompanyTools.Size = new Size(256, 351);
            panelCompanyTools.TabIndex = 9;
            // 
            // buttonAddCar
            // 
            buttonAddCar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddCar.Location = new Point(3, 13);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(244, 47);
            buttonAddCar.TabIndex = 1;
            buttonAddCar.Text = "Добавление машины";
            buttonAddCar.UseVisualStyleBackColor = true;
            buttonAddCar.Click += ButtonAddCar_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRefresh.Location = new Point(3, 292);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(244, 47);
            buttonRefresh.TabIndex = 7;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // maskedTextBoxPosition
            // 
            maskedTextBoxPosition.Location = new Point(6, 140);
            maskedTextBoxPosition.Mask = "00";
            maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            maskedTextBoxPosition.Size = new Size(238, 27);
            maskedTextBoxPosition.TabIndex = 3;
            maskedTextBoxPosition.ValidatingType = typeof(int);
            // 
            // buttonGoToCheck
            // 
            buttonGoToCheck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonGoToCheck.Location = new Point(3, 226);
            buttonGoToCheck.Name = "buttonGoToCheck";
            buttonGoToCheck.Size = new Size(244, 47);
            buttonGoToCheck.TabIndex = 6;
            buttonGoToCheck.Text = "Отправить на полигон";
            buttonGoToCheck.UseVisualStyleBackColor = true;
            buttonGoToCheck.Click += ButtonGoToCheck_Click;
            // 
            // buttonRemoveCar
            // 
            buttonRemoveCar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRemoveCar.Location = new Point(3, 173);
            buttonRemoveCar.Name = "buttonRemoveCar";
            buttonRemoveCar.Size = new Size(244, 47);
            buttonRemoveCar.TabIndex = 5;
            buttonRemoveCar.Text = "Удалить машину";
            buttonRemoveCar.UseVisualStyleBackColor = true;
            buttonRemoveCar.Click += ButtonRemoveCar_Click;
            // 
            // panelStorage
            // 
            panelStorage.Controls.Add(buttonCreateCompany);
            panelStorage.Controls.Add(buttonCollectionDel);
            panelStorage.Controls.Add(listBoxCollection);
            panelStorage.Controls.Add(buttonCollectionAdd);
            panelStorage.Controls.Add(radioButtonList);
            panelStorage.Controls.Add(radioButtonMassive);
            panelStorage.Controls.Add(textBoxCollectionName);
            panelStorage.Controls.Add(labelCollectionName);
            panelStorage.Controls.Add(comboBoxSelectorCompany);
            panelStorage.Dock = DockStyle.Top;
            panelStorage.Location = new Point(3, 23);
            panelStorage.Name = "panelStorage";
            panelStorage.Size = new Size(244, 343);
            panelStorage.TabIndex = 8;
            // 
            // buttonCreateCompany
            // 
            buttonCreateCompany.Location = new Point(3, 307);
            buttonCreateCompany.Name = "buttonCreateCompany";
            buttonCreateCompany.Size = new Size(238, 29);
            buttonCreateCompany.TabIndex = 7;
            buttonCreateCompany.Text = "Создать компанию";
            buttonCreateCompany.UseVisualStyleBackColor = true;
            buttonCreateCompany.Click += ButtonCreateCompany_Click;
            // 
            // buttonCollectionDel
            // 
            buttonCollectionDel.Location = new Point(3, 238);
            buttonCollectionDel.Name = "buttonCollectionDel";
            buttonCollectionDel.Size = new Size(238, 29);
            buttonCollectionDel.TabIndex = 6;
            buttonCollectionDel.Text = "Удалить коллекцию";
            buttonCollectionDel.UseVisualStyleBackColor = true;
            buttonCollectionDel.Click += ButtonCollectionDel_Click;
            // 
            // listBoxCollection
            // 
            listBoxCollection.FormattingEnabled = true;
            listBoxCollection.Location = new Point(3, 128);
            listBoxCollection.Name = "listBoxCollection";
            listBoxCollection.Size = new Size(241, 104);
            listBoxCollection.TabIndex = 5;
            // 
            // buttonCollectionAdd
            // 
            buttonCollectionAdd.Location = new Point(3, 93);
            buttonCollectionAdd.Name = "buttonCollectionAdd";
            buttonCollectionAdd.Size = new Size(238, 29);
            buttonCollectionAdd.TabIndex = 4;
            buttonCollectionAdd.Text = "Добавить коллекцию";
            buttonCollectionAdd.UseVisualStyleBackColor = true;
            buttonCollectionAdd.Click += ButtonCollectionAdd_Click;
            // 
            // radioButtonList
            // 
            radioButtonList.AutoSize = true;
            radioButtonList.Location = new Point(134, 65);
            radioButtonList.Name = "radioButtonList";
            radioButtonList.Size = new Size(80, 24);
            radioButtonList.TabIndex = 3;
            radioButtonList.TabStop = true;
            radioButtonList.Text = "Список";
            radioButtonList.UseVisualStyleBackColor = true;
            // 
            // radioButtonMassive
            // 
            radioButtonMassive.AutoSize = true;
            radioButtonMassive.Location = new Point(32, 65);
            radioButtonMassive.Name = "radioButtonMassive";
            radioButtonMassive.Size = new Size(82, 24);
            radioButtonMassive.TabIndex = 2;
            radioButtonMassive.TabStop = true;
            radioButtonMassive.Text = "Массив";
            radioButtonMassive.UseVisualStyleBackColor = true;
            // 
            // textBoxCollectionName
            // 
            textBoxCollectionName.Location = new Point(3, 32);
            textBoxCollectionName.Name = "textBoxCollectionName";
            textBoxCollectionName.Size = new Size(238, 27);
            textBoxCollectionName.TabIndex = 1;
            // 
            // labelCollectionName
            // 
            labelCollectionName.AutoSize = true;
            labelCollectionName.Location = new Point(47, 9);
            labelCollectionName.Name = "labelCollectionName";
            labelCollectionName.Size = new Size(155, 20);
            labelCollectionName.TabIndex = 0;
            labelCollectionName.Text = "Название коллекции";
            // 
            // comboBoxSelectorCompany
            // 
            comboBoxSelectorCompany.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSelectorCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectorCompany.FormattingEnabled = true;
            comboBoxSelectorCompany.Items.AddRange(new object[] { "Хранилище" });
            comboBoxSelectorCompany.Location = new Point(0, 273);
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
            pictureBox.Size = new Size(840, 723);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // FormCarCollection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 723);
            Controls.Add(pictureBox);
            Controls.Add(groupBoxTools);
            Name = "FormCarCollection";
            Text = "Коллекция машин";
            groupBoxTools.ResumeLayout(false);
            panelCompanyTools.ResumeLayout(false);
            panelCompanyTools.PerformLayout();
            panelStorage.ResumeLayout(false);
            panelStorage.PerformLayout();
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
        private Button buttonRefresh;
        private Panel panelStorage;
        private Label labelCollectionName;
        private TextBox textBoxCollectionName;
        private Button buttonCollectionAdd;
        private RadioButton radioButtonList;
        private RadioButton radioButtonMassive;
        private Button buttonCollectionDel;
        private ListBox listBoxCollection;
        private Button buttonCreateCompany;
        private Panel panelCompanyTools;
    }
}