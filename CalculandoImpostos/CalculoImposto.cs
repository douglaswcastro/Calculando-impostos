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
        int opcao;
        public void Calculo()
        {
            Empresa empresa = new Empresa();
            Cliente cliente = new Cliente();
            NotaFiscal notaFiscal = new NotaFiscal();

            Console.WriteLine("Digite seu CNPJ");
            empresa.cnpj = Console.ReadLine();
            if (notas.Any(n => n.empresa.cnpj.Equals(empresa.cnpj)))
            {
                Console.WriteLine("Digite o nome da Empresa");
                empresa.nome = Console.ReadLine();
            }
            Console.WriteLine("1 - Emitir nova nota fiscal\n" +
                    "2 - Cadastrar notas anteriores\n" +
                    "3 - Consultar notas anteriores\n");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o valor da nota fiscal");
                    Console.WriteLine("Digite o CNPJ do cliente");
                    Console.WriteLine("Digite o nome do cliente");
                    Console.WriteLine("Deseja emitir a nota? Sim/Nao");
                    string emissaonota = Console.ReadLine();
                    if (emissaonota.ToUpper() == "SIM")
                    {

                    }
                    else if (emissaonota.ToUpper() == "NAO" || emissaonota.ToUpper() == "NÃO")
                    {

                    }
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
            }

            notaFiscal.empresa = empresa;
            notaFiscal.cliente = cliente;

            notas.Add(notaFiscal);
        }
        public void AtualizaNota() { }
    }
}
