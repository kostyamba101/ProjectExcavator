namespace ProjectExcavator
{
    partial class FormExcavator
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
            pictureBoxExcavator = new PictureBox();
            buttonCreateExcavator = new Button();
            buttonLeft = new Button();
            buttonUp = new Button();
            buttonRight = new Button();
            buttonDown = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExcavator).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxExcavator
            // 
            pictureBoxExcavator.Dock = DockStyle.Fill;
            pictureBoxExcavator.Location = new Point(0, 0);
            pictureBoxExcavator.Name = "pictureBoxExcavator";
            pictureBoxExcavator.Size = new Size(1080, 513);
            pictureBoxExcavator.TabIndex = 0;
            pictureBoxExcavator.TabStop = false;
            // 
            // buttonCreateExcavator
            // 
            buttonCreateExcavator.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreateExcavator.Location = new Point(12, 472);
            buttonCreateExcavator.Name = "buttonCreateExcavator";
            buttonCreateExcavator.Size = new Size(94, 29);
            buttonCreateExcavator.TabIndex = 1;
            buttonCreateExcavator.Text = "Создать";
            buttonCreateExcavator.UseVisualStyleBackColor = true;
            buttonCreateExcavator.Click += ButtonCreateExcavator_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLeft.BackgroundImage = Properties.Resources.left;
            buttonLeft.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLeft.Location = new Point(948, 465);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(35, 35);
            buttonLeft.TabIndex = 2;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += ButtonMove_Click;
            // 
            // buttonUp
            // 
            buttonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUp.BackgroundImage = Properties.Resources.top;
            buttonUp.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUp.Location = new Point(989, 424);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(35, 35);
            buttonUp.TabIndex = 3;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += ButtonMove_Click;
            // 
            // buttonRight
            // 
            buttonRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRight.BackgroundImage = Properties.Resources.right;
            buttonRight.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRight.Location = new Point(1030, 465);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(35, 35);
            buttonRight.TabIndex = 4;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += ButtonMove_Click;
            // 
            // buttonDown
            // 
            buttonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDown.BackgroundImage = Properties.Resources.bottom;
            buttonDown.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDown.Location = new Point(989, 465);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(35, 35);
            buttonDown.TabIndex = 5;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += ButtonMove_Click;
            // 
            // FormExcavator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 513);
            Controls.Add(buttonDown);
            Controls.Add(buttonRight);
            Controls.Add(buttonUp);
            Controls.Add(buttonLeft);
            Controls.Add(buttonCreateExcavator);
            Controls.Add(pictureBoxExcavator);
            Name = "FormExcavator";
            Text = "Экскаватор";
            ((System.ComponentModel.ISupportInitialize)pictureBoxExcavator).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxExcavator;
        private Button buttonCreateExcavator;
        private Button buttonLeft;
        private Button buttonUp;
        private Button buttonRight;
        private Button buttonDown;
    }
}