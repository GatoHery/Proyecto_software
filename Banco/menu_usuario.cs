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
    public partial class menu_usuario : Form
    {
        Form loginForm;
        public menu_usuario(Form loginFrm)
        {
            InitializeComponent();
            loginForm = loginFrm;
        }

        private void menu_usuario_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transferencia money = new Transferencia();
            money.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //agregar funcion de eliminar
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountDetails_user details = new AccountDetails_user();
            details.ShowDialog();
        }
    }
}
