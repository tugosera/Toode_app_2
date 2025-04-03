using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toode_app_2
{
    public partial class FormDeleteCategory : Form
    {
        public string CategoryId { get; private set; }  // Теперь CategoryId - строка

        public FormDeleteCategory()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCategoryId.Text))
            {
                CategoryId = txtCategoryId.Text.Trim();  // Убираем лишние пробелы и сохраняем ввод
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("ID категории не может быть пустым.");
            }
        }
    }
}
