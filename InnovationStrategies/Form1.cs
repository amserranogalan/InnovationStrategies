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
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            InfringementTypeService its = new InfringementTypeService();

            its.AddInfringement(txtInfringement.Text, decimal.ToInt32(nudPoints.Value));

            its = null;

            txtInfringement.Text = "";
            nudPoints.Value=1;
        }

        private void btnOkDriver_Click(object sender, EventArgs e)
        {
            DriversService ds = new DriversService();

            ds.AddDriver(txtDni.Text, txtName.Text, txtSurnames.Text);

            ds = null;

            txtDni.Text = "";
            txtName.Text = "";
            txtSurnames.Text = "";
        }

        private void btnOkInfringement_Click(object sender, EventArgs e)
        {
            if (txtVehicle.Text != "")
            {
                InfringementDriversService ids = new InfringementDriversService();

                try
                {
                    ids.AddInfringement(Convert.ToInt32(cmbNumberInfringement.SelectedValue.ToString()), txtVehicle.Text);
                    ids = null;
                }
                catch (InvalidOperationException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                txtVehicle.Text = "";
                cmbNumberInfringement.SelectedIndex = 0;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Introduzca la matrícula del vehículo.");
            }
        }

        private void btnOkVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                VehiclesService vs = new VehiclesService();

                vs.AddVehicle(txtVehicleRegistration.Text, txtBrand.Text, txtModel.Text, txtDniConductorHabitual.Text);

                vs = null;
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

        private void btnVehicleDriver_Click(object sender, EventArgs e)
        {
            if (txtVehicleDriver.Text != "" && txtDniDriver.Text != "")
            {
                try
                {
                    VehicleDriversService vds = new VehicleDriversService();

                    vds.AddDriver(txtVehicleDriver.Text, txtDniDriver.Text);

                    vds = null;

                    txtVehicleDriver.Text = "";
                    txtDniDriver.Text = "";
                }
                catch (InvalidOperationException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }          
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Introduzca el DNI y la matrícula del vehículo.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvHabitualInfractions.DataSource = InfringementDrivers.HabitualInfractions();
        }
    }
}
