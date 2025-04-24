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
            City1textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // City1textBox1
            // 
            City1textBox1.Location = new Point(17, 26);
            City1textBox1.Name = "City1textBox1";
            City1textBox1.Size = new Size(198, 23);
            City1textBox1.TabIndex = 0;
            City1textBox1.TextChanged += City1textBox1_TextChanged;
            // 
            // City1textBox2
            // 
            City1textBox2.Location = new Point(231, 26);
            City1textBox2.Name = "City1textBox2";
            City1textBox2.Size = new Size(219, 23);
            City1textBox2.TabIndex = 1;
            City1textBox2.TextChanged += City1textBox2_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(17, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(13, 283);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(515, 283);
            button2.Name = "button2";
            button2.Size = new Size(150, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(478, 30);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Location = new Point(202, 283);
            button3.Name = "button3";
            button3.Size = new Size(191, 23);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AirPlaneFlightsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(City1textBox2);
            Controls.Add(City1textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AirPlaneFlightsForm";
            Text = "AirPlaneFlightsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox City1textBox1;
        private TextBox City1textBox2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
    }
}