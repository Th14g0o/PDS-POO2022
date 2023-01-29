using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOzap
{
    internal class Membro
    {
        public int Id { get; set; }
        public int IdGrupo { get; set; }
        public int IdContato { get; set; }
        public bool Adm { get; set; }
        public override string ToString()
        {
            if (Adm == true)
                return "Administrador";
            else
                return null;
        }
    }
}
