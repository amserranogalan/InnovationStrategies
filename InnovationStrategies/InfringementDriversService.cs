using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationStrategies
{
    class InfringementDriversService
    {
        public static void AddInfringement(int NumberInfringement, string VehicleRegistration)
        {
            //Construimos la nueva infracción
            InfringementDrivers id = new InfringementDrivers();

            id.Date = DateTime.Now;
            id.NumberInfringement = NumberInfringement;
            id.VehicleRegistration = VehicleRegistration;

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
        }
    }
}
