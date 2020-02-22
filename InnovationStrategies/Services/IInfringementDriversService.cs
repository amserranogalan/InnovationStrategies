using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationStrategies
{
    public interface IInfringementDriversService
    {
        void AddInfringement(int NumberInfringement, string VehicleRegistration);
    }
}
