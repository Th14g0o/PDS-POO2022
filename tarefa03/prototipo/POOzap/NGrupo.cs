using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOzap
{
    internal static class NGrupo
    {
        private static List<Grupo> grupos = new List<Grupo>();
        public static List<Grupo> Listar()
        {
            return grupos;
        }
    }
}
