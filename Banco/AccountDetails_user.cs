using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Models;
using Banco.Queries;

namespace Banco
{
    public partial class AccountDetails_user : Form
    {
        public AccountDetails_user(string id_owner, string account_id)
        {
            InitializeComponent();
            showInfo(id_owner, account_id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showInfo(string id_owner, string account_id)
        {
            AccountInfo account = new AccountInfo();

            account = AccountQuery.getCustomerAccount(account_id, id_owner);

            label2.Text = account.account_name;
            label4.Text = account.account_number;
            if (account.account_type == '1') label6.Text = "Ahorro";
            else label6.Text = "Corriente";
            label8.Text = "$ " + account.account_amount.ToString();
        }

        private void AccountDetails_user_Load(object sender, EventArgs e)
        {

        }
    }
}
