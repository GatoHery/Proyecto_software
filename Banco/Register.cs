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
    public partial class Register : Form
    {
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
            if(textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals("")){
                MessageBox.Show("Hay campos vacíos");
            }
            else {
                try{
                    User newUser = new User();
                    newUser.id_user = textBox2.Text;
                    newUser.name = textBox1.Text;
                    newUser.username = textBox3.Text;
                    newUser.email = textBox4.Text;
                    newUser.password = textBox5.Text;

                    AccountInfo newAccount = new AccountInfo();
                    newAccount.account_name = newUser.name;
                    newAccount.account_type = 1;
                    if(radioButton2.Checked) newAccount.account_type = 2;
                    newAccount.account_amount = 0.0;
                    newAccount.id_owner = newUser.id_user;

                    UserQuery.registerUser(newUser);
                    AccountQuery.createAccount(newAccount);

                    MessageBox.Show("Cuenta creada.\nRegresará al menú principal.");
                }
                catch(Exception ex){
                    MessageBox.Show("Ocurrió un error " + ex.ToString());
                }
            }
            this.Close();
        }
    }
}
