using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assinaturas.Entities
{
    public class Assinatura
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdAssinaturaTipo { get; set; }
        public decimal Valor { get; set; }
        public string Nome { get; set; }
    }
}
