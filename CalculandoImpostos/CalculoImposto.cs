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
            string cnpj = Console.ReadLine();
            if (!notas.Any(n => n.empresa.cnpj.Equals(cnpj)))
            {
                Console.WriteLine("Digite o nome da Empresa");
                empresa.nome = Console.ReadLine();
            }
            else
            {
                empresa.cnpj = cnpj;
                empresa.nome = notas.First(n => n.empresa.cnpj == cnpj).empresa.nome;
            }

            Console.WriteLine("1 - Emitir nova nota fiscal\n" +
                    "2 - Cadastrar notas anteriores\n" +
                    "3 - Consultar notas anteriores\n");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o valor da nota fiscal");
                    notaFiscal.valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o CNPJ do cliente");
                    cliente.cnpj = Console.ReadLine();
                    Console.WriteLine("Digite o nome do cliente");
                    cliente.nome = Console.ReadLine();
                    Console.WriteLine("Deseja emitir a nota? Sim/Nao");
                    string emissaonota = Console.ReadLine();

                    if (emissaonota.ToUpper() == "SIM")
                    {
                        notaFiscal.empresa = empresa;
                        notaFiscal.cliente = cliente;
                        notaFiscal.mes = DateTime.Now.Date.ToShortDateString().Remove(0, 3);
                        notas.Add(notaFiscal);

                    }
                    else if (emissaonota.ToUpper() == "NAO" || emissaonota.ToUpper() == "NÃO")
                    {

                    }
                    break;
                case 2:
                    Console.WriteLine("Digite o valor da nota fiscal");
                    notaFiscal.valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o CNPJ do cliente");
                    cliente.cnpj = Console.ReadLine();
                    Console.WriteLine("Digite o nome do cliente");
                    cliente.nome = Console.ReadLine();
                    Console.WriteLine("Digite o mes da emissao");
                    notaFiscal.mes = Console.ReadLine();
                    notaFiscal.empresa = empresa;
                    notaFiscal.cliente = cliente;
                    notas.Add(notaFiscal);
                    break;
                case 3:
                    Console.WriteLine("1 - Consultar por Cliente\n" +
                        "2 - Consultar por Mes");
                    string consulta = Console.ReadLine();
                    switch (consulta)
                    {
                        case "1":
                            Console.WriteLine("Digite o CNPJ do cliente");
                            string cnpjConsulta = Console.ReadLine();
                            if (!notas.Any(n => n.empresa.cnpj.Equals(cnpjConsulta)))
                            {
                                Console.WriteLine("Cliente não encontrado");
                            }
                            else if (notas.Any())
                            {
                                Console.WriteLine("Mês Emissão\t Valor");
                                foreach (var nota in notas.Where(n => n.empresa.cnpj.Equals(cnpjConsulta)))
                                {
                                    Console.WriteLine($"{nota.mes}\t R${nota.total} \n");
                                }
                            }
                            break;
                        case "2":
                            Console.WriteLine("Cliente \t Mês Emissão \t Valor");
                            foreach (var nota in notas.Where(n => n.mes == DateTime.Now.Date.ToShortDateString().Remove(0, 3)))
                            {
                                Console.WriteLine($"{nota.mes}\t R${nota.total} \n");
                            }
                            break;
                    }
                    break;
            }


        }
    }
}
