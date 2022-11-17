using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            bool flag = false;

            List<AccountInfo> accountsList = AccountQuery.getAllAccounts();
            try
            {
                foreach (var a in accountsList)
                {
                    if (textBox1.Text.Equals(a.id_owner) && textBox2.Text.Equals(a.id_account.ToString()))
                    {
                        AccountDetails details = new AccountDetails(textBox1.Text, textBox2.Text);
                        details.Show();
                        this.Close();
                        flag = true;
                        break;
                    }
                }

                if(!flag) MessageBox.Show("No se encontró la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error" + ex.ToString());
            }
        }
    }
}
