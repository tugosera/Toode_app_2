using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Xml.Linq;

namespace Toode_app_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                Console.WriteLine(column.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toodeDataSet1.tooded' table. You can move, or remove it, as needed.
            this.toodedTableAdapter.Fill(this.toodeDataSet1.tooded);

        }
        private void dataGridView1_CellClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=toode;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                
                connection.Open();
                // Проверяем, кликнули ли на корректную строку (а не на заголовок)
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Заполняем текстовые поля
                    txtToodeNimetus.Text = row.Cells["nimetusDataGridViewTextBoxColumn"].Value?.ToString();
                    txtKogus.Text = row.Cells["kogusDataGridViewTextBoxColumn"].Value?.ToString();
                    txtHind.Text = row.Cells["hindDataGridViewTextBoxColumn"].Value?.ToString(); 
                    txtKategooria.Text = row.Cells["kategooriaidDataGridViewTextBoxColumn"].Value?.ToString();


                    // Загружаем изображение в pictureBox
                    try
                    {
                        string imageName = row.Cells["piltDataGridViewTextBoxColumn"].Value?.ToString();
                        if (!string.IsNullOrEmpty(imageName))
                        {
                            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                            string imagePath = Path.Combine(projectDirectory, "images", imageName);

                            //MessageBox.Show("Путь к изображению: " + imagePath); // Проверяем путь

                            if (File.Exists(imagePath))
                            {
                                if (pictureBox1.Image != null)
                                {
                                    pictureBox1.Image.Dispose();
                                }

                                byte[] imageBytes = File.ReadAllBytes(imagePath);
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    pictureBox1.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Файл не найден!");
                                pictureBox1.Image = null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пустое имя файла");
                            pictureBox1.Image = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
                    }
                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void lisaBtn_Click(object sender, EventArgs e)
        {
            // Проверяем, что все текстовые поля заполнены
            if (string.IsNullOrWhiteSpace(txtToodeNimetus.Text) ||
                string.IsNullOrWhiteSpace(txtKogus.Text) ||
                string.IsNullOrWhiteSpace(txtHind.Text) ||
                string.IsNullOrWhiteSpace(txtKategooria.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            // Запрос на добавление изображения
            MessageBox.Show("Добавьте изображение", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    string imagesFolder = Path.Combine(projectDirectory, "images");
                    string imageName = Path.GetFileName(imagePath);
                    string destinationPath = Path.Combine(imagesFolder, imageName);

                    if (!Directory.Exists(imagesFolder))
                    {
                        Directory.CreateDirectory(imagesFolder);
                    }

                    File.Copy(imagePath, destinationPath, true);

                    // Подключение к базе данных и добавление новой записи
                    string connectionString = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=toode;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO tooded (nimetus, kogus, hind, kategooria_id, pilt) VALUES (@nimetus, @kogus, @hind, @kategooria_id, @pilt)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nimetus", txtToodeNimetus.Text);
                            command.Parameters.AddWithValue("@kogus", int.Parse(txtKogus.Text));
                            command.Parameters.AddWithValue("@hind", decimal.Parse(txtHind.Text));
                            command.Parameters.AddWithValue("@kategooria_id", txtKategooria.Text);
                            command.Parameters.AddWithValue("@pilt", imageName);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Запись успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.toodedTableAdapter.Fill(this.toodeDataSet1.tooded);
                }
                else
                {
                    MessageBox.Show("Вы не выбрали изображение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void kustutaBtn_Click(object sender, EventArgs e)
        {
            // Проверяем, что поле для наименования товара не пустое
            if (string.IsNullOrEmpty(txtToodeNimetus.Text))
            {
                MessageBox.Show("Пожалуйста, введите наименование товара для удаления.");
                return;
            }

            // Получаем наименование товара из текстового поля
            string nimetus = txtToodeNimetus.Text;

            string connectionString = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=toode;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL запрос для удаления записи по наименованию товара
                    string query = "DELETE FROM tooded WHERE nimetus = @nimetus";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nimetus", nimetus);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Запись успешно удалена.");
                            // Обновляем данные на форме
                            this.toodedTableAdapter.Fill(this.toodeDataSet1.tooded);
                        }
                        else
                        {
                            MessageBox.Show("Запись с таким наименованием не найдена.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении записи: " + ex.Message);
                }
            }
        }

        private void uuendaBtn_Click(object sender, EventArgs e)
        {

            string uusNimetus = txtToodeNimetus.Text;
            string uusKogus = txtKogus.Text;
            string uusHind = txtHind.Text;
            string uusKategooria = txtKategooria.Text;
            // Создаем и отображаем форму для ввода ID
            InputIdForm inputForm = new InputIdForm();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                string inputId = inputForm.ProductId;

                // Проверяем введенный ID
                if (string.IsNullOrEmpty(inputId))
                {
                    MessageBox.Show("Вы не ввели ID!");
                    return;
                }

                int id;
                if (!int.TryParse(inputId, out id))
                {
                    MessageBox.Show("Неверный формат ID. Пожалуйста, введите целое число.");
                    return;
                }

                string connectionString = "Data Source=HOME\\SQLEXPRESS;Initial Catalog=toode;Integrated Security=True";
                string currentImageName = "";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // SQL запрос для получения текущих данных по ID
                        string query = "SELECT * FROM tooded WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Загружаем данные из базы в текстовые поля
                                    txtToodeNimetus.Text = reader["nimetus"].ToString();
                                    txtKogus.Text = reader["kogus"].ToString();
                                    txtHind.Text = reader["hind"].ToString();
                                    txtKategooria.Text = reader["kategooria_id"].ToString();
                                    currentImageName = reader["pilt"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Продукт с таким ID не найден.");
                                    return;
                                }
                            }
                        }

                        // Просим пользователя загрузить новое изображение
                        OpenFileDialog openFileDialog = new OpenFileDialog();
                        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                        string newImageName = currentImageName; // По умолчанию оставляем старое изображение

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string newImagePath = openFileDialog.FileName;
                            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                            string imagesFolder = Path.Combine(projectDirectory, "images");

                            if (!Directory.Exists(imagesFolder))
                            {
                                Directory.CreateDirectory(imagesFolder);
                            }

                            // Генерируем новое имя файла и копируем изображение
                            newImageName = Path.GetFileName(newImagePath);
                            string newImageDestination = Path.Combine(imagesFolder, newImageName);

                            File.Copy(newImagePath, newImageDestination, true);
                        }

                        // Теперь обновляем все данные в базе, независимо от загрузки изображения
                        string updateQuery = "UPDATE tooded SET nimetus = @nimetus, kogus = @kogus, hind = @hind, kategooria_id = @kategooria_id, pilt = @pilt WHERE id = @id";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@nimetus", uusNimetus);
                            updateCmd.Parameters.AddWithValue("@kogus", uusKogus);
                            updateCmd.Parameters.AddWithValue("@hind", uusHind);
                            updateCmd.Parameters.AddWithValue("@kategooria_id", uusKategooria);
                            updateCmd.Parameters.AddWithValue("@pilt", newImageName); // Если новое изображение не выбрано, остается старое
                            updateCmd.Parameters.AddWithValue("@id", id);

                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {

                                MessageBox.Show("Запись успешно обновлена.");
                                // Обновляем данные на форме
                                this.toodedTableAdapter.Fill(this.toodeDataSet1.tooded);
                            }
                            else
                            {
                                MessageBox.Show("Ошибка при обновлении записи.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
        }


    }
}






//Data Source=HOME\SQLEXPRESS;Initial Catalog=toode;Integrated Security=True;Trust Server Certificate=True
