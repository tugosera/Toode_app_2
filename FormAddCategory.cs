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
    public partial class FormAddCategory : Form
    {
        public string CategoryName { get; private set; }

        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryName = txtCategoryName.Text;

            if (string.IsNullOrWhiteSpace(CategoryName))
            {
                MessageBox.Show("Название категории не может быть пустым.");
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
