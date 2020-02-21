using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationStrategies
{
    class VehicleDriversService
    {
        public static void AddDriver(string VehicleRegistration, string Dni)
        {
            VehicleDrivers vd = new VehicleDrivers();

            vd.Dni = Dni;
            vd.VehicleRegistration = VehicleRegistration;

            if (Vehicles.Exist(vd.VehicleRegistration))
            {
                if (Drivers.Exist(vd.Dni))
                {
                    vd.Add();

                    System.Windows.Forms.MessageBox.Show("Registro grabado");

                    vd = null;
                }
                else
                {
                    throw new System.InvalidOperationException("No existe un conductor con ese DNI.");
                }
            }
            else
            {
                throw new System.InvalidOperationException("No existe un vehículo con esa matrícula.");
            }
        }
    }
}
