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
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                res = res * (k * k * k);
            }
            return Math.Round(res,3);
        }
    }
}
