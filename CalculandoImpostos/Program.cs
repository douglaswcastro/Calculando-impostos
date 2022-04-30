using System;

namespace CalculandoImpostos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculoImposto calculoImposto = new CalculoImposto();
            calculoImposto.Calculo();
        }
    }
}