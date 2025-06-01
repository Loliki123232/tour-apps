namespace WinFormsApp1
{
    partial class TrainFlightsForm
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
            btnExit = new Button();
            btnCheck = new Button();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            City2textBox = new TextBox();
            City1textBox = new TextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(3, 365);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 29);
            btnExit.TabIndex = 21;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(206, 365);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(137, 29);
            btnCheck.TabIndex = 22;
            btnCheck.Text = "Просмотр цены";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(399, 365);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 29);
            btnSave.TabIndex = 23;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 67);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 16;
            label4.Text = "Дата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(486, 37);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 17;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 9);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 18;
            label2.Text = "Куда";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 19;
            label1.Text = "От куда";
            // 
            // City2textBox
            // 
            City2textBox.Location = new Point(249, 37);
            City2textBox.Name = "City2textBox";
            City2textBox.Size = new Size(217, 27);
            City2textBox.TabIndex = 14;
            City2textBox.TextChanged += City2textBox_TextChanged;
            // 
            // City1textBox
            // 
            City1textBox.Location = new Point(12, 37);
            City1textBox.Name = "City1textBox";
            City1textBox.Size = new Size(217, 27);
            City1textBox.TabIndex = 15;
            City1textBox.TextChanged += City1textBox_TextChanged;
            // 
            // TrainFlightsForm
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
            Name = "TrainFlightsForm";
            Text = "TrainFlightsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnCheck;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox City2textBox;
        private TextBox City1textBox;
    }
}