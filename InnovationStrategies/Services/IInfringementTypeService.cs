using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationStrategies
{
    public interface IInfringementTypeService
    {
        void AddInfringement(string infringement, int points);
    }
}
