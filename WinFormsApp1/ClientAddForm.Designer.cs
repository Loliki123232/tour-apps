namespace WinFormsApp1
{
    partial class ClientAddForm
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
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            MiddleNameTextBox = new TextBox();
            NumberTextBox = new TextBox();
            NumberCardTextBox = new TextBox();
            ValidUntilTextBox = new TextBox();
            CCVTextBox = new TextBox();
            ExitButton = new Button();
            SaveInfoButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(29, 63);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(448, 27);
            FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(29, 116);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(448, 27);
            LastNameTextBox.TabIndex = 0;
            // 
            // MiddleNameTextBox
            // 
            MiddleNameTextBox.Location = new Point(29, 169);
            MiddleNameTextBox.Name = "MiddleNameTextBox";
            MiddleNameTextBox.Size = new Size(448, 27);
            MiddleNameTextBox.TabIndex = 0;
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(29, 222);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(448, 27);
            NumberTextBox.TabIndex = 0;
            // 
            // NumberCardTextBox
            // 
            NumberCardTextBox.Location = new Point(29, 275);
            NumberCardTextBox.Name = "NumberCardTextBox";
            NumberCardTextBox.Size = new Size(205, 27);
            NumberCardTextBox.TabIndex = 0;
            // 
            // ValidUntilTextBox
            // 
            ValidUntilTextBox.Location = new Point(240, 275);
            ValidUntilTextBox.Name = "ValidUntilTextBox";
            ValidUntilTextBox.Size = new Size(88, 27);
            ValidUntilTextBox.TabIndex = 0;
            // 
            // CCVTextBox
            // 
            CCVTextBox.Location = new Point(334, 275);
            CCVTextBox.Name = "CCVTextBox";
            CCVTextBox.Size = new Size(88, 27);
            CCVTextBox.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(29, 385);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(150, 29);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "назад";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SaveInfoButton
            // 
            SaveInfoButton.Location = new Point(240, 385);
            SaveInfoButton.Name = "SaveInfoButton";
            SaveInfoButton.Size = new Size(150, 29);
            SaveInfoButton.TabIndex = 2;
            SaveInfoButton.Text = "сохранить";
            SaveInfoButton.UseVisualStyleBackColor = true;
            SaveInfoButton.Click += SaveInfoButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 3;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 93);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 146);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 199);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 252);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 3;
            label5.Text = "Номер карты";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 252);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 3;
            label6.Text = "Годен до";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(334, 252);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 3;
            label7.Text = "CCV";
            // 
            // ClientAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SaveInfoButton);
            Controls.Add(ExitButton);
            Controls.Add(CCVTextBox);
            Controls.Add(ValidUntilTextBox);
            Controls.Add(NumberCardTextBox);
            Controls.Add(NumberTextBox);
            Controls.Add(MiddleNameTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Name = "ClientAddForm";
            Text = "ClientAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox MiddleNameTextBox;
        private TextBox NumberTextBox;
        private TextBox NumberCardTextBox;
        private TextBox ValidUntilTextBox;
        private TextBox CCVTextBox;
        private Button ExitButton;
        private Button SaveInfoButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}