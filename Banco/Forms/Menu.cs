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
    public partial class Menu : Form
    {
        Form loginForm;
        public Menu(Form loginFrm)
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(222, 234, 238);
            button2.BackColor = Color.FromArgb(222, 234, 238);
            button3.BackColor = Color.FromArgb(222, 234, 238);
            button4.BackColor = Color.FromArgb(112, 195, 223);
            button5.BackColor = Color.FromArgb(112, 195, 223);

            loginForm = loginFrm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit_money deposit = new Deposit_money();
            deposit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remove_money withdraw = new Remove_money();
            withdraw.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Account viewAccount = new Account();
            viewAccount.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Login login = new Login();
            loginForm.Show();
            this.Close();
            //login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuTransfer menuTransfer = new MenuTransfer();
            menuTransfer.ShowDialog();
        }

        /*private void Menu_Load(object sender, EventArgs e)
        {

        }*/
    }
}
