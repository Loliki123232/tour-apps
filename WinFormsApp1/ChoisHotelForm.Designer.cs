namespace WinFormsApp1
{
    partial class ChoisHotelForm
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
            starComboBox = new ComboBox();
            priceLabel = new Label();
            resultTextBox = new TextBox();
            mealsCheckedListBox = new CheckedListBox();
            amenitiesCheckedListBox = new CheckedListBox();
            excursionsCheckedListBox = new CheckedListBox();
            button1 = new Button();
            btnExit = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // starComboBox
            // 
            starComboBox.FormattingEnabled = true;
            starComboBox.Location = new Point(12, 23);
            starComboBox.Name = "starComboBox";
            starComboBox.Size = new Size(151, 28);
            starComboBox.TabIndex = 0;
            starComboBox.SelectedIndexChanged += starComboBox_SelectedIndexChanged;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(637, 27);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(50, 20);
            priceLabel.TabIndex = 1;
            priceLabel.Text = "label1";
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(12, 147);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(608, 232);
            resultTextBox.TabIndex = 2;
            // 
            // mealsCheckedListBox
            // 
            mealsCheckedListBox.FormattingEnabled = true;
            mealsCheckedListBox.Location = new Point(169, 27);
            mealsCheckedListBox.Name = "mealsCheckedListBox";
            mealsCheckedListBox.Size = new Size(150, 114);
            mealsCheckedListBox.TabIndex = 3;
            // 
            // amenitiesCheckedListBox
            // 
            amenitiesCheckedListBox.FormattingEnabled = true;
            amenitiesCheckedListBox.Location = new Point(325, 27);
            amenitiesCheckedListBox.Name = "amenitiesCheckedListBox";
            amenitiesCheckedListBox.Size = new Size(150, 114);
            amenitiesCheckedListBox.TabIndex = 3;
            // 
            // excursionsCheckedListBox
            // 
            excursionsCheckedListBox.FormattingEnabled = true;
            excursionsCheckedListBox.Location = new Point(481, 27);
            excursionsCheckedListBox.Name = "excursionsCheckedListBox";
            excursionsCheckedListBox.Size = new Size(150, 114);
            excursionsCheckedListBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(233, 418);
            button1.Name = "button1";
            button1.Size = new Size(203, 29);
            button1.TabIndex = 4;
            button1.Text = "Посмотр цены";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buildButton_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(24, 418);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(203, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(442, 418);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ChoisHotelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 522);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(button1);
            Controls.Add(excursionsCheckedListBox);
            Controls.Add(amenitiesCheckedListBox);
            Controls.Add(mealsCheckedListBox);
            Controls.Add(resultTextBox);
            Controls.Add(priceLabel);
            Controls.Add(starComboBox);
            Name = "ChoisHotelForm";
            Text = "ChoisHotelForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox starComboBox;
        private Label priceLabel;
        private TextBox resultTextBox;
        private CheckedListBox mealsCheckedListBox;
        private CheckedListBox amenitiesCheckedListBox;
        private CheckedListBox excursionsCheckedListBox;
        private Button button1;
        private Button btnExit;
        private Button btnSave;
    }
}