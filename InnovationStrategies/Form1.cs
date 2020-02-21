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
            InfringementType it = new InfringementType();

            it.Infringement=txtInfringement.Text;
            it.Points=decimal.ToInt32(nudPoints.Value);

            it.Add();

            it=null;

            System.Windows.Forms.MessageBox.Show("Registro grabado");

            txtInfringement.Text = "";
            nudPoints.Value=1;
        }

        private void btnOkDriver_Click(object sender, EventArgs e)
        {
            Drivers driver = new Drivers();

            driver.Dni = txtDni.Text;
            driver.Name = txtName.Text;
            driver.Surnames = txtSurnames.Text;

            if (driver.Exist())
            {
                System.Windows.Forms.MessageBox.Show("Ya existe un cliente con este DNI.");
            }
            else
            {
                driver.Add();
                System.Windows.Forms.MessageBox.Show("Registro grabado");
            }
            
            driver = null;

            txtDni.Text = "";
            txtName.Text = "";
            txtSurnames.Text = "";
        }

        private void btnOkInfringement_Click(object sender, EventArgs e)
        {
            //Construimos la nueva infracción
            InfringementDrivers id = new InfringementDrivers();

            id.Date = DateTime.Now;
            id.NumberInfringement = Convert.ToInt32(cmbNumberInfringement.SelectedValue.ToString());
            id.VehicleRegistration = txtVehicle.Text;

            //Usamos la matrícula del vehículo para rescatar los datos del conductor habitual
            Vehicles v = new Vehicles(id.VehicleRegistration);

            id.Dni = v.Dni;

            id.Add();

            //Construimos una clase conductor para ejecutar la sanción
            Drivers d = new Drivers(id.Dni);

            //Usamos el tipo de infracción introducido para rescatar los puntos de sanción de dicha infracción
            InfringementType it = new InfringementType(id.NumberInfringement);

            //Llamamos a la función que resta los puntos de ese tipo de infracción
            d.Sanction(it.Points);

            System.Windows.Forms.MessageBox.Show("Infracción introducida - el conductor:" + d.Name + " " + d.Surnames + " ha sido sancionado con: " + it.Points + " puntos.");

            id = null;
            d = null;
            it = null;
            v = null;

            txtVehicle.Text = "";
            cmbNumberInfringement.SelectedIndex = 0;
        }

        private void btnOkVehicles_Click(object sender, EventArgs e)
        {
            Vehicles v = new Vehicles();

            v.VehicleRegistration=txtVehicleRegistration.Text;
            v.Brand=txtBrand.Text;
            v.Model=txtModel.Text;
            v.Dni=txtDniConductorHabitual.Text;

            if (v.Exist())
            {
                System.Windows.Forms.MessageBox.Show("Ya existe un vehículo con esa matrícula.");
            }
            else
            {
                if (!Drivers.Exist(v.Dni))
                {
                    System.Windows.Forms.MessageBox.Show("El DNI del conductor introducido no existe.");
                }
                else
                {
                    v.Add();
                    System.Windows.Forms.MessageBox.Show("Registro grabado");
                }
            }
            
            v=null;

            txtDniConductorHabitual.Text="";
            txtBrand.Text="";
            txtModel.Text="";
            txtVehicleRegistration.Text="";
        }
    }
}
