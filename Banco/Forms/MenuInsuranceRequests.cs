using Banco.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Forms
{
    public partial class MenuInsuranceRequests : Form
    {
        Form loginForm;

        public MenuInsuranceRequests(Form loginFrm)
        {
            InitializeComponent();
            loginForm = loginFrm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Por favor, introduzca la información necesaria");
            }
            else if (textBox1.Text.Length != 9)
            {
                MessageBox.Show("El DUI ingresado no es valido");
            }
            else
            {
                try
                {
                    if (InsuranceCustomerQuery.CheckCustomerExist(textBox1.Text) && VehicleQuery.CheckVehicleExist(textBox2.Text, textBox1.Text))
                    {
                        VehicleInsuranceRequestInfo requestInfo = new VehicleInsuranceRequestInfo(textBox1.Text, textBox2.Text);
                        requestInfo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró información con esos parámetros");

                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show("No se encontró información con esos parámetros");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error" + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
