namespace WinFormsApp1
{
    partial class AdminWorkForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageClients = new TabPage();
            dataGridViewClients = new DataGridView();
            tabPageHotels = new TabPage();
            dataGridViewHotels = new DataGridView();
            btnRefresh = new Button();
            btnExport = new Button();
            btnExit = new Button();
            tabControl1.SuspendLayout();
            tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            tabPageHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHotels).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageClients);
            tabControl1.Controls.Add(tabPageHotels);
            tabControl1.Location = new Point(16, 18);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1013, 615);
            tabControl1.TabIndex = 0;
            // 
            // tabPageClients
            // 
            tabPageClients.Controls.Add(dataGridViewClients);
            tabPageClients.Location = new Point(4, 29);
            tabPageClients.Margin = new Padding(4, 5, 4, 5);
            tabPageClients.Name = "tabPageClients";
            tabPageClients.Padding = new Padding(4, 5, 4, 5);
            tabPageClients.Size = new Size(1005, 582);
            tabPageClients.TabIndex = 0;
            tabPageClients.Text = "Клиенты";
            tabPageClients.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Dock = DockStyle.Fill;
            dataGridViewClients.Location = new Point(4, 5);
            dataGridViewClients.Margin = new Padding(4, 5, 4, 5);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.Size = new Size(997, 572);
            dataGridViewClients.TabIndex = 0;
            dataGridViewClients.CellEndEdit += dataGridViewClients_CellEndEdit;
            dataGridViewClients.UserDeletingRow += dataGridViewClients_UserDeletingRow;
            // 
            // tabPageHotels
            // 
            tabPageHotels.Controls.Add(dataGridViewHotels);
            tabPageHotels.Location = new Point(4, 29);
            tabPageHotels.Margin = new Padding(4, 5, 4, 5);
            tabPageHotels.Name = "tabPageHotels";
            tabPageHotels.Padding = new Padding(4, 5, 4, 5);
            tabPageHotels.Size = new Size(1005, 582);
            tabPageHotels.TabIndex = 1;
            tabPageHotels.Text = "Отели";
            tabPageHotels.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHotels
            // 
            dataGridViewHotels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHotels.Dock = DockStyle.Fill;
            dataGridViewHotels.Location = new Point(4, 5);
            dataGridViewHotels.Margin = new Padding(4, 5, 4, 5);
            dataGridViewHotels.Name = "dataGridViewHotels";
            dataGridViewHotels.RowHeadersWidth = 51;
            dataGridViewHotels.Size = new Size(997, 572);
            dataGridViewHotels.TabIndex = 0;
            dataGridViewHotels.CellEndEdit += dataGridViewHotels_CellEndEdit;
            dataGridViewHotels.UserDeletingRow += dataGridViewHotels_UserDeletingRow;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(380, 648);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(133, 46);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(569, 650);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(133, 46);
            btnExport.TabIndex = 2;
            btnExport.Text = "Экспорт";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(16, 648);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(133, 48);
            btnExit.TabIndex = 3;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // AdminWorkForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 708);
            Controls.Add(btnExit);
            Controls.Add(btnExport);
            Controls.Add(btnRefresh);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminWorkForm";
            Text = "Панель администратора";
            tabControl1.ResumeLayout(false);
            tabPageClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            tabPageHotels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHotels).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageHotels;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewHotels;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private Button btnExit;
    }
}