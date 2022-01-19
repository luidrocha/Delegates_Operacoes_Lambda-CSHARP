using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMultCast.Services
{
    class CalculationService
    {
        public static void  ShowMax(double x, double y)
        {
            double max =  (x > y) ? x : y; // ( ? : ) condição ? expressão1_se_true : expressão2_se_false, 
            Console.WriteLine(max);


        }
        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
        }
       
    }
}

