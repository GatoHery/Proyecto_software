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
    public partial class AccountDetails : Form
    {
        public AccountDetails(string id_owner, string account_id)
        {
            InitializeComponent();

            showInfo(id_owner, account_id);
        }

        private void showInfo(string id_owner, string account_id)
        {
            AccountInfo account = new AccountInfo();

            account = AccountQuery.getCustomerAccount(id_owner, Convert.ToInt32(account_id));

            label2.Text = account.account_name;
            label4.Text = account.id_account.ToString();
            if (account.account_type == 1) label6.Text = "Ahorro";
            else label6.Text = "Corriente";
            label8.Text = account.account_amount.ToString();
        }
    }
}
