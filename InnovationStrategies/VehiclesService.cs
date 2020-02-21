using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationStrategies
{
    class VehiclesService
    {
        public static void AddVehicle(string vRegistration, string brand, string model, string dni)
        {
            Vehicles v = new Vehicles();

            v.VehicleRegistration = vRegistration;
            v.Brand = brand;
            v.Model = model;
            v.Dni = dni;

            if (v.Exist())
            {
                throw new System.InvalidOperationException("Ya existe un vehículo con esa matrícula.");
            }
            else
            {
                if (!Drivers.Exist(v.Dni))
                {
                    throw new System.InvalidOperationException("El DNI del conductor introducido no existe.");
                }
                else
                {
                    if (Drivers.TotalVehicles(v.Dni)>=10)
                    {
                        throw new System.InvalidOperationException("Este conductor ya es conductor habitual de 10 vehículos."); 
                    }
                    else
                    {
                        v.Add();
                        System.Windows.Forms.MessageBox.Show("Registro grabado");
                    }
                }
            }

            v = null;
        }
    }
}
