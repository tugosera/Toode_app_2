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
        public int CategoryId { get; private set; }

        public FormDeleteCategory()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCategoryId.Text, out int id) && id > 0)
            {
                CategoryId = id;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Некорректный ID. Пожалуйста, введите положительное целое число.");
            }
        }
    }
}
