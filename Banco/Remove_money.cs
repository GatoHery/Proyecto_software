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
    public partial class Remove_money : Form
    {
        public Remove_money()
        {
            InitializeComponent();
            textBox1.BackColor = Color.FromArgb(222, 234, 238);
            button1.BackColor = Color.FromArgb(112, 195, 223);
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
                    if (textBox1.Text.Equals(a.id_account.ToString()) && textBox2.Text.Equals(a.id_owner))
                    {
                        Transaction t = new Transaction();
                        //t.date = DateTime.Now;
                        t.transaction_amount = Convert.ToDouble(textBox3.Text);
                        t.account_id = Convert.ToInt32(textBox1.Text);
                        t.transaction_type = 2;

                        TransactionQuery.newTransaction(t);

                        AccountInfo acc = new AccountInfo();
                        acc = AccountQuery.getCustomerAccount(a.id_owner, a.id_account);

                        double balance = acc.account_amount;
                        MessageBox.Show("El balance actual es: " + balance.ToString());
                        balance -= Convert.ToDouble(textBox3.Text);

                        MessageBox.Show("Se retiró la cantidad de\n$" + textBox3.Text);

                        AccountQuery.updateAccountBalance(balance, acc);

                        textBox1.Text = " ";
                        textBox2.Text = " ";
                        textBox3.Text = " ";



                        flag = true;
                        break;
                    }
                }

                if (!flag) MessageBox.Show("No se encontró la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error" + ex.ToString());
            }
        }
    }
}
