using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOzap
{
    internal class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Recado { get; set; }
        public string Telefone { get; set; }
        public override string ToString()
        {
            return $"[{Id}] {Nome} - {Recado} - {Telefone}";
        }
    }
}
