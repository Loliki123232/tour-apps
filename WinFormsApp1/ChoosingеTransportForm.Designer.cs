namespace WinFormsApp1
{
    partial class ChoosingеTransportForm
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
            AirPlaneButton = new Button();
            TrainButton = new Button();
            BusButton = new Button();
            ShipButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // AirPlaneButton
            // 
            AirPlaneButton.Location = new Point(12, 91);
            AirPlaneButton.Name = "AirPlaneButton";
            AirPlaneButton.Size = new Size(191, 136);
            AirPlaneButton.TabIndex = 0;
            AirPlaneButton.Text = "Самолёт";
            AirPlaneButton.UseVisualStyleBackColor = true;
            AirPlaneButton.Click += AirPlaneButton_Click;
            // 
            // TrainButton
            // 
            TrainButton.Location = new Point(209, 91);
            TrainButton.Name = "TrainButton";
            TrainButton.Size = new Size(191, 136);
            TrainButton.TabIndex = 0;
            TrainButton.Text = "Поезд";
            TrainButton.UseVisualStyleBackColor = true;
            TrainButton.Click += TrainButton_Click;
            // 
            // BusButton
            // 
            BusButton.Location = new Point(406, 91);
            BusButton.Name = "BusButton";
            BusButton.Size = new Size(191, 136);
            BusButton.TabIndex = 0;
            BusButton.Text = "Автобус";
            BusButton.UseVisualStyleBackColor = true;
            BusButton.Click += BusButton_Click;
            // 
            // ShipButton
            // 
            ShipButton.Location = new Point(603, 91);
            ShipButton.Name = "ShipButton";
            ShipButton.Size = new Size(191, 136);
            ShipButton.TabIndex = 0;
            ShipButton.Text = "Корабль";
            ShipButton.UseVisualStyleBackColor = true;
            ShipButton.Click += ShipButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(12, 310);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(191, 30);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "назад";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ChoosingеTransportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 388);
            Controls.Add(ShipButton);
            Controls.Add(BusButton);
            Controls.Add(ExitButton);
            Controls.Add(TrainButton);
            Controls.Add(AirPlaneButton);
            Name = "ChoosingеTransportForm";
            Text = "ChoosingеTransportForm";
            ResumeLayout(false);
        }

        #endregion

        private Button AirPlaneButton;
        private Button TrainButton;
        private Button BusButton;
        private Button ShipButton;
        private Button ExitButton;
    }
}