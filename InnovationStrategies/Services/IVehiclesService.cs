using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationStrategies
{
    public interface IVehiclesService
    {
        void AddVehicle(string vRegistration, string brand, string model, string dni);
    }
}
