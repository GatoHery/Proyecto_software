using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security;

namespace Banco
{
    public partial class Register : Form
    {
        private static RandomNumberGenerator generator = RandomNumberGenerator.Create();
        public Register()
        {
            InitializeComponent();
            textBox1.BackColor = Color.FromArgb(222, 234, 238);
            textBox2.BackColor = Color.FromArgb(222, 234, 238);
            textBox3.BackColor = Color.FromArgb(222, 234, 238);
            button1.BackColor = Color.FromArgb(112, 195, 223);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "10";

            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacíos");
            }
            else if (textBox2.Text.Length != 9)
            {
                MessageBox.Show("Por favor, compruebe el DUI");
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
                MessageBox.Show("Por favor, elija un tipo de cuenta", "Cuenta no especificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    User newUser = new User();
                    newUser.id_user = textBox2.Text;
                    newUser.name = textBox1.Text;
                    newUser.username = textBox3.Text;
                    newUser.email = textBox4.Text;
                    newUser.password = textBox5.Text;

                    AccountInfo newAccount = new AccountInfo();
                    newAccount.account_name = newUser.name;

                    if (radioButton1.Checked)
                    {
                        newAccount.account_type = '1';
                        str = "10";
                    }
                    if (radioButton2.Checked)
                    {
                        newAccount.account_type = '2';
                        str = "20";
                    }
                    newAccount.account_amount = 0.0;
                    newAccount.id_owner = newUser.id_user;

                    var accountNumber = new byte[5];
                    generator.GetBytes(accountNumber);

                    foreach (var s in accountNumber)
                    {
                        str += s.ToString();
                    }

                    newAccount.account_number = str;

                    UserQuery.registerUser(newUser);
                    AccountQuery.createAccount(newAccount);

                    MessageBox.Show("Se creó la cuenta con el número:\n" + newAccount.account_number, "Cuenta creada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MessageBox.Show("Cuenta creada.\nRegresará al menú principal.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error " + ex.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
