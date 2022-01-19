using System;
using Delegates_E_Operacoes_Lambda.Services;

namespace Delegates_E_Operacoes_Lambda
{

    delegate double BinaryNumericOperation(double n1, double n2); // Cria um delegate que recebe 2 argumentos
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            // BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            // double result = op(a, b);
            double result = op.Invoke(a, b); // Funciona sem a função INVOKE
            Console.WriteLine(result);
        }
    }

}

