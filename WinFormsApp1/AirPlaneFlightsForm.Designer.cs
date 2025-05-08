namespace WinFormsApp1
{
    partial class AirPlaneFlightsForm
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
            City1textBox1 = new TextBox();
            City2textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnExit = new Button();
            btnSave = new Button();
            label1 = new Label();
            btnCheck = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // City1textBox1
            // 
            City1textBox1.Location = new Point(15, 40);
            City1textBox1.Margin = new Padding(3, 4, 3, 4);
            City1textBox1.Name = "City1textBox1";
            City1textBox1.Size = new Size(226, 27);
            City1textBox1.TabIndex = 0;
            City1textBox1.TextChanged += City1textBox1_TextChanged;
            // 
            // City2textBox2
            // 
            City2textBox2.Location = new Point(264, 40);
            City2textBox2.Margin = new Padding(3, 4, 3, 4);
            City2textBox2.Name = "City2textBox2";
            City2textBox2.Size = new Size(250, 27);
            City2textBox2.TabIndex = 1;
            City2textBox2.TextChanged += City1textBox2_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(15, 95);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(15, 377);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(165, 31);
            btnExit.TabIndex = 3;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(546, 377);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(171, 31);
            btnSave.TabIndex = 4;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(546, 40);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(249, 377);
            btnCheck.Margin = new Padding(3, 4, 3, 4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(218, 31);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Просмотр цены";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 9);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 7;
            label2.Text = "От куда";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 9);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 7;
            label3.Text = "Куда";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 71);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 7;
            label4.Text = "Дата";
            // 
            // AirPlaneFlightsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnCheck);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(dateTimePicker1);
            Controls.Add(City2textBox2);
            Controls.Add(City1textBox1);
            Name = "AirPlaneFlightsForm";
            Text = "AirPlaneFlightsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox City1textBox1;
        private TextBox City2textBox2;
        private DateTimePicker dateTimePicker1;
        private Button btnExit;
        private Button btnSave;
        private Label label1;
        private Button btnCheck;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}