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
            comboBoxFlights = new ComboBox();
            labelPrice = new Label();
            labelDate = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // comboBoxFlights
            // 
            comboBoxFlights.FormattingEnabled = true;
            comboBoxFlights.Location = new Point(12, 33);
            comboBoxFlights.Name = "comboBoxFlights";
            comboBoxFlights.Size = new Size(269, 28);
            comboBoxFlights.TabIndex = 0;
            comboBoxFlights.SelectedIndexChanged += AirPlaneFlightsComboBox;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(339, 33);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(50, 20);
            labelPrice.TabIndex = 1;
            labelPrice.Text = "label1";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(566, 33);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(50, 20);
            labelDate.TabIndex = 1;
            labelDate.Text = "label1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 83);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // AirPlaneFlightsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(labelDate);
            Controls.Add(labelPrice);
            Controls.Add(comboBoxFlights);
            Name = "AirPlaneFlightsForm";
            Text = "AirPlaneFlightsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFlights;
        private Label labelPrice;
        private Label labelDate;
        private CheckBox checkBox1;
    }
}