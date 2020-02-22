using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationStrategies
{
    class InfringementTypeService : IInfringementTypeService
    {
        public void AddInfringement(string infringement, int points)
        {
            InfringementType it = new InfringementType();

            it.Infringement = infringement;
            it.Points = decimal.ToInt32(points);

            it.Add();

            it = null;

            System.Windows.Forms.MessageBox.Show("Registro grabado");
        }
    }
}
