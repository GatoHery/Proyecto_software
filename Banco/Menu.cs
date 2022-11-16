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
        public Menu()
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(222, 234, 238);
            button2.BackColor = Color.FromArgb(222, 234, 238);
            button3.BackColor = Color.FromArgb(222, 234, 238);
            button4.BackColor = Color.FromArgb(112, 195, 223);
            button5.BackColor = Color.FromArgb(112, 195, 223);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit_money depositar = new Deposit_money();
            depositar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deposit_money depositar = new Deposit_money();
            depositar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Account money2 = new Account();
            money2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
