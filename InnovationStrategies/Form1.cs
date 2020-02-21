using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InnovationStrategies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbNumberInfringement.DataSource = InfringementType.GetAll();
            cmbNumberInfringement.ValueMember="number";
            cmbNumberInfringement.DisplayMember = "infringement";

            dgvHabitualInfractions.DataSource = InfringementDrivers.HabitualInfractions();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            InfringementTypeService.AddInfringement(txtInfringement.Text, decimal.ToInt32(nudPoints.Value));

            txtInfringement.Text = "";
            nudPoints.Value=1;
        }

        private void btnOkDriver_Click(object sender, EventArgs e)
        {
            DriverService.AddDriver(txtDni.Text, txtName.Text, txtSurnames.Text);

            txtDni.Text = "";
            txtName.Text = "";
            txtSurnames.Text = "";
        }

        private void btnOkInfringement_Click(object sender, EventArgs e)
        {
            InfringementDriversService.AddInfringement(Convert.ToInt32(cmbNumberInfringement.SelectedValue.ToString()), txtVehicle.Text);

            txtVehicle.Text = "";
            cmbNumberInfringement.SelectedIndex = 0;
        }

        private void btnOkVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                VehiclesService.AddVehicle(txtVehicleRegistration.Text, txtBrand.Text, txtModel.Text, txtDniConductorHabitual.Text);
            }
            catch(InvalidOperationException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
            txtDniConductorHabitual.Text="";
            txtBrand.Text="";
            txtModel.Text="";
            txtVehicleRegistration.Text="";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtSearchDni.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Introduzca el DNI del conductor.");
            }
            else
            {
                dgvHistory.DataSource=InfringementDrivers.GetByDriver(txtSearchDni.Text);
            }
        }

        private void btnSearchTopDrivers_Click(object sender, EventArgs e)
        {
            dgvTopDrivers.DataSource = Drivers.Top(decimal.ToInt32(nudTop.Value));
        }
    }
}
