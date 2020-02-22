using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationStrategies
{
    public class DriversService : IDriversService
    {
        public void AddDriver(string dni, string name, string surname)
        {
            Drivers driver = new Drivers();

            driver.Dni = dni;
            driver.Name = name;
            driver.Surnames = surname;

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
        }
    }
}
