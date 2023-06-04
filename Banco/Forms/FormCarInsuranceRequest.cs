using Banco.Models;
using Banco.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Forms
{
    public partial class FormCarInsuranceRequest : Form
    {
        Form loginForm;
        public FormCarInsuranceRequest(Form loginFrm)
        {
            InitializeComponent();
            loginForm = loginFrm;
        }

        private bool CheckTextBox()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void ClearTextBox()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = String.Empty;
                }
            }
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox() || comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Hay campos vacíos");
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Por favor, indique si el cliente cuenta con licencia de conducir");
            }
            else if (float.Parse(textBox6.Text) < 0 || float.Parse(textBox12.Text) < 0)
            {
                MessageBox.Show("No puede ingresar cantidades menores a 0");
            }
            else
            {
                try
                {
                    InsuranceCustomer customer = new InsuranceCustomer();
                    Car car = new Car();
                    CarInsuranceRequest request = new CarInsuranceRequest();

                    customer.Name = textBox1.Text;
                    customer.Id = textBox2.Text;
                    customer.Email = textBox3.Text;
                    customer.Phone = textBox4.Text;
                    customer.Address = textBox5.Text;
                    customer.Employment = comboBox1.Text;
                    customer.Earnings = float.Parse(textBox6.Text);
                    customer.HasLicense = radioButton1.Checked;

                    car.Make = textBox7.Text;
                    car.Model = textBox8.Text;
                    car.Year = textBox9.Text;
                    car.Plate = textBox10.Text;
                    car.Vin = textBox11.Text;
                    car.Usage = comboBox2.Text;
                    car.Value = float.Parse(textBox12.Text);
                    car.IssuedToId = textBox2.Text;
                    car.IsApproved = false;

                    request.VehiclePlate = textBox10.Text;
                    request.CustomerId = textBox2.Text;
                    request.State = "Pendiente";

                    InsuranceCustomerQuery.RegisterInsuranceCustomer(customer);
                    VehicleQuery.AddInsuredVehicle(car);
                    CarInsuranceRequestQuery.NewRequest(request);

                    MessageBox.Show("Solicitud enviada");

                    ClearTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error" + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
