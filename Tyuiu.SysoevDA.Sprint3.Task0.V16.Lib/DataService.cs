using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SysoevDA.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetSumSeries(double value)
        {
            double res = 1;
            for (int k = 1; k < value + 1; k++)
            {
                res = res * (k * k * k);
            }
            return res;
        }
    }
}
