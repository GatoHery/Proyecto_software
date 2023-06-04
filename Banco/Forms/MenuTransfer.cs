using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Models;
using Banco.Queries;

namespace Banco
{
    public partial class MenuTransfer : Form
    {
        public MenuTransfer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AccountInfo accountSender = AccountQuery.getCustomerAccount(textBox1.Text, textBox4.Text);
                AccountInfo accountReceiver = AccountQuery.GetCustomerAccountByName(textBox2.Text, textBox3.Text);
                
                Transaction t = new Transaction();
                t.account_number = textBox1.Text;
                t.transaction_amount = Convert.ToDouble(textBox5.Text);
                t.transaction_comment = "Transferencia a cuenta " + accountReceiver.account_number;
                t.transaction_type = '3';
                    
                double balance = accountSender.account_amount;
                balance -= Convert.ToDouble(textBox5.Text);

                if (balance < Convert.ToDouble(textBox5.Text))
                {
                    MessageBox.Show("No hay fondos suficientes en la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AccountQuery.updateAccountBalance(balance, accountSender);
                    TransactionQuery.newTransaction(t);
                    
                    t.account_number = textBox2.Text;
                    t.transaction_amount = Convert.ToDouble(textBox5.Text);
                    t.transaction_comment = "Transferencia desde cuenta " + accountSender.account_number;
                    t.transaction_type = '4';
                    
                    balance = accountReceiver.account_amount;
                    balance += Convert.ToDouble(textBox5.Text);
                    AccountQuery.updateAccountBalance(balance, accountReceiver);
                    TransactionQuery.newTransaction(t);
                    
                    MessageBox.Show("Se ha realizado la transferencia por el monto de:\n$" + textBox5.Text);
                    
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
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
                Console.WriteLine(ex);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
