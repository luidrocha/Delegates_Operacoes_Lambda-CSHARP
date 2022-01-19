using System;
using DelegateMultCast.Services;

namespace DelegateMultCast
{
    delegate void BinaryNumericOperator(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            // Delegate guarda a referencia par 2 funções
            BinaryNumericOperator op = CalculationService.ShowMax;
            op += CalculationService.ShowSum;

            op.Invoke(a, b); // Executa as duas funções em sequencia referencias em OP 
           
            op(a, b); // funciona da msma forma. 



        }
    }
}
