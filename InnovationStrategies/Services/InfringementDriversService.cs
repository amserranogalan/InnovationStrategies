using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationStrategies
{
    class InfringementDriversService : IInfringementDriversService
    {
        public void AddInfringement(int NumberInfringement, string VehicleRegistration)
        {
            //We build the new infraction
            InfringementDrivers id = new InfringementDrivers();

            id.Date = DateTime.Now;
            id.NumberInfringement = NumberInfringement;
            id.VehicleRegistration = VehicleRegistration;

            //We use the vehicle registration to rescue the data of the usual driver
            Vehicles v = new Vehicles(id.VehicleRegistration);

            if (!v.Exist())
            {
                throw new System.InvalidOperationException("El vehículo no existe.");
            }
            else
            {
                id.Dni = v.Dni;

                id.Add();

                //We build a driver class to execute the sanction
                Drivers d = new Drivers(id.Dni);

                //We use the type of infraction introduced to rescue the penalty points
                InfringementType it = new InfringementType(id.NumberInfringement);

                //We call the function that subtracts the points of that type of infraction
                d.Sanction(it.Points);

                System.Windows.Forms.MessageBox.Show("Infracción introducida - el conductor:" + d.Name + " " + d.Surnames + " ha sido sancionado con: " + it.Points + " puntos.");

                id = null;
                d = null;
                it = null;
                v = null;
            }            
        }
    }
}
