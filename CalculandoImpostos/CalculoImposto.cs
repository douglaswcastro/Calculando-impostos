using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoImpostos
{
    public class CalculoImposto
    {

        List<NotaFiscal> notas = new List<NotaFiscal>();
        string cnpf;
        public void Calculo()
        {
            Console.WriteLine("Digite seu CNPJ");
            cnpf = Console.ReadLine();
            if (!notas.Any(n => n.empresa.cnpj.Equals(cnpf))) { }

        }
    }
}
