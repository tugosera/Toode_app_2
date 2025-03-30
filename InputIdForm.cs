using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Toode_app_2
{
    public partial class InputIdForm : Form
    {
        public string ProductId { get; private set; }

        public InputIdForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите ID.");
            }
            else
            {
                ProductId = idTextBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
