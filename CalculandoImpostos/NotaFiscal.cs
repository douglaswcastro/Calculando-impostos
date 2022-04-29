using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoImpostos
{
    internal class NotaFiscal
    {
        public Empresa empresa { get; set; }
        public Cliente cliente { get; set; }
        public double? valor { get; set; }
        public string? mes { get; set; }
        public double? IRPJ { get; set; }
        public double? CSLL { get; set; }
        public double? COFINS { get; set; }
        public double? PIS { get; set; }
        public double? INSS { get; set; }
        public double? ISS { get; set; }
        public double? total { get; set; }

    }
}
