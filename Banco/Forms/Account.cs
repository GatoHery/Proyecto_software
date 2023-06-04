using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Queries;

namespace Banco
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            textBox1.BackColor = Color.FromArgb(222, 234, 238);
            textBox2.BackColor = Color.FromArgb(222, 234, 238);
            button1.BackColor = Color.FromArgb(112, 195, 223);
            button2.BackColor = Color.FromArgb(112, 195, 223);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string response = AccountQuery.CheckCustomerAccount(textBox2.Text);
                if (textBox1.Text.Equals(response))
                {
                    AccountDetails details = new AccountDetails(textBox1.Text, textBox2.Text);
                    details.ShowDialog();
                }
                else throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("No se encontró la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error" + ex.ToString());
            }
        }
    }
}
