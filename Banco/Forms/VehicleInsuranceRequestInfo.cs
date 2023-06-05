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
    public partial class VehicleInsuranceRequestInfo : Form
    {
        public VehicleInsuranceRequestInfo(string customerId, string vehiclePlate)
        {
            InitializeComponent();

            QueryInfo(customerId, vehiclePlate);
        }

        private void FillCustomerInfo(InsuranceCustomer customer)
        {
            labelFullname.Text = customer.Name;
            labelID.Text = customer.Id;
            labelEmail.Text = customer.Email;
            labelPhone.Text = customer.Phone;
            labelAddress.Text = customer.Address;
            labelEmployment.Text = customer.Employment;
            labelEarnings.Text = customer.Earnings.ToString();
            if (customer.HasLicense) labelLicense.Text = "Sí";
            else labelLicense.Text = "No";
        }

        private void FillVehicleInfo(Car vehicle)
        {
            labelCarMake.Text = vehicle.Make;
            labelCarModel.Text = vehicle.Model;
            labelCarYear.Text = vehicle.Year;
            labelCarPlate.Text = vehicle.Plate;
            labelCarVin.Text = vehicle.Vin;
            labelCarUsage.Text = vehicle.Usage;
            labelCarValue.Text = vehicle.Value.ToString();
            if (vehicle.IsApproved) labelCarApproved.Text = "Asegurado";
            else labelCarApproved.Text = "No asegurado";
        }

        private void QueryInfo(string customerId, string vehiclePlate)
        {
            InsuranceCustomer customer = new InsuranceCustomer();
            Car vehicle = new Car();

            customer = InsuranceCustomerQuery.GetInsuranceCustomer(customerId);
            vehicle = VehicleQuery.GetVehicle(vehiclePlate);

            FillCustomerInfo(customer);
            FillVehicleInfo(vehicle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
