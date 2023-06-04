using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Banco.Queries;
using Banco.Models;

namespace Banco
{
    public partial class Deposit_money : Form
    {
        public Deposit_money()
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
            try
            {
                string response = AccountQuery.CheckCustomerAccount(textBox1.Text);
                if (textBox2.Text.Equals(response))
                {
                    AccountInfo account = AccountQuery.getCustomerAccount(textBox1.Text, textBox2.Text);

                    Transaction t = new Transaction();
                    t.account_number = textBox1.Text;
                    t.transaction_amount = Convert.ToDouble(textBox3.Text);
                    //t.transaction_comment = textBox4.Text; // TODO
                    t.transaction_type = '2';

                    TransactionQuery.newTransaction(t);

                    double balance = account.account_amount;
                    balance += Convert.ToDouble(textBox3.Text);

                    MessageBox.Show("Se ha aplicado un abono por\n$" + textBox3.Text);

                    AccountQuery.updateAccountBalance(balance, account);

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else throw new IndexOutOfRangeException();

                //if (!flag) MessageBox.Show("No se encontró la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("No se encontró la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (RuntimeWrappedException ex)
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
