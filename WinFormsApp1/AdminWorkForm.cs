using CommonLibrary;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminWorkForm : Form
    {
        private BdManager bdManager = new BdManager();

        public AdminWorkForm()
        {
            InitializeComponent();
            LoadData();
            SetupDataGridViews();
        }

        private void SetupDataGridViews()
        {
            // Настройка таблицы клиентов
            dataGridViewClients.AutoGenerateColumns = true;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.AllowUserToDeleteRows = true;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            // Настройка таблицы отелей
            dataGridViewHotels.AutoGenerateColumns = true;
            dataGridViewHotels.AllowUserToAddRows = false;
            dataGridViewHotels.AllowUserToDeleteRows = true;
            dataGridViewHotels.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
        }

        private void LoadData()
        {
            // Загрузка клиентов
            dataGridViewClients.DataSource = bdManager.GetAllClients();

            // Загрузка отелей
            dataGridViewHotels.DataSource = bdManager.GetAllHotels();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // Редактирование клиентов
        private void dataGridViewClients_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridViewClients.Rows[e.RowIndex].Cells["ID"].Value);
                string email = dataGridViewClients.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                string password = dataGridViewClients.Rows[e.RowIndex].Cells["Password"].Value.ToString();

                if (bdManager.UpdateClient(id, email, password))
                {
                    MessageBox.Show("Данные клиента обновлены", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData();
            }
        }

        // Удаление клиента
        private void dataGridViewClients_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Удалить этого клиента?", "Подтверждение",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                int id = Convert.ToInt32(e.Row.Cells["ID"].Value);
                if (!bdManager.DeleteClient(id))
                {
                    MessageBox.Show("Не удалось удалить клиента", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        // Редактирование отелей
        private void dataGridViewHotels_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridViewHotels.Rows[e.RowIndex].Cells["Id"].Value);
                int stars = Convert.ToInt32(dataGridViewHotels.Rows[e.RowIndex].Cells["Stars"].Value);
                decimal price = Convert.ToDecimal(dataGridViewHotels.Rows[e.RowIndex].Cells["TotalPrice"].Value);
                string meals = dataGridViewHotels.Rows[e.RowIndex].Cells["Meals"].Value.ToString();
                string amenities = dataGridViewHotels.Rows[e.RowIndex].Cells["Amenities"].Value.ToString();
                string excursions = dataGridViewHotels.Rows[e.RowIndex].Cells["Excursions"].Value.ToString();

                if (bdManager.UpdateHotel(id, stars, price, meals, amenities, excursions))
                {
                    MessageBox.Show("Данные отеля обновлены", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData();
            }
        }

        // Удаление отеля
        private void dataGridViewHotels_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Удалить этот отель?", "Подтверждение",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                int id = Convert.ToInt32(e.Row.Cells["Id"].Value);
                if (!bdManager.DeleteHotel(id))
                {
                    MessageBox.Show("Не удалось удалить отель", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        // Экспорт данных
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV файл (*.csv)|*.csv";
            saveFileDialog.Title = "Экспорт данных";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataGridView dataGridView = tabControl1.SelectedIndex == 0 ? dataGridViewClients : dataGridViewHotels;
                ExportToCsv(dataGridView, saveFileDialog.FileName);
            }
        }

        private void ExportToCsv(DataGridView dataGridView, string fileName)
        {
            try
            {
                
                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    // Заголовки (первая строка)
                    var headers = dataGridView.Columns
                        .Cast<DataGridViewColumn>()
                        .Select(column => EscapeCsvValue(column.HeaderText));

                    writer.WriteLine(string.Join(",", headers));

                    // Данные
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            var cells = row.Cells
                                .Cast<DataGridViewCell>()
                                .Select(cell => EscapeCsvValue(cell.Value?.ToString() ?? ""));

                            writer.WriteLine(string.Join(",", cells));
                        }
                    }
                }

                MessageBox.Show("Данные успешно экспортированы", "Успех",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string EscapeCsvValue(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            // Если значение содержит запятые, кавычки или переносы строк - обрамляем в кавычки
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\r") || value.Contains("\n"))
            {
                // Экранируем кавычки внутри значения (удваиваем их)
                return $"\"{value.Replace("\"", "\"\"")}\"";
            }

            return value;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginAdminForm loginAdminForm = new LoginAdminForm();
            loginAdminForm.Show();
        }
    }
}