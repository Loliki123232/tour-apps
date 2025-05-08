namespace WinFormsApp1
{
    partial class ShipFlightsForm
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
            City1textBox = new TextBox();
            City2textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnSave = new Button();
            btnCheck = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // City1textBox
            // 
            City1textBox.Location = new Point(21, 37);
            City1textBox.Name = "City1textBox";
            City1textBox.Size = new Size(217, 27);
            City1textBox.TabIndex = 0;
            City1textBox.TextChanged += City1textBox_TextChanged;
            // 
            // City2textBox
            // 
            City2textBox.Location = new Point(258, 37);
            City2textBox.Name = "City2textBox";
            City2textBox.Size = new Size(217, 27);
            City2textBox.TabIndex = 0;
            City2textBox.TextChanged += City2textBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "От куда";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 9);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Куда";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 37);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 67);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 1;
            label4.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(408, 365);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(215, 365);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(137, 29);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "Просмотр цены";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 365);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ShipFlightsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnCheck);
            Controls.Add(btnSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(City2textBox);
            Controls.Add(City1textBox);
            Name = "ShipFlightsForm";
            Text = "ShipFlightsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox City1textBox;
        private TextBox City2textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button btnSave;
        private Button btnCheck;
        private Button btnExit;
    }
}