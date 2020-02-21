using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace InnovationStrategies
{
    public interface IDrivers
    {
        void Add();
        bool Exist();
        void Sanction(int points);
    }
}