using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace POOzap
{
    internal static class NGrupo
    {
        private static List<Grupo> grupos = new List<Grupo>();
        public static List<Grupo> Listar()
        {
            Abrir();
            return grupos;
        }

        public static void Inserir (Grupo g)
        {
            Abrir();
            grupos.Add(g);
            Salvar();
        }
        public static void Salvar()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Grupo>));
            StreamWriter f = new StreamWriter("./grupos.xml", false);
            x.Serialize(f, grupos);
            f.Close();
            
        }

        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Grupo>));
                f = new StreamReader("./grupos.xml");
                grupos = (List<Grupo>) x.Deserialize(f);
            }
            catch
            {
                grupos = new List<Grupo>();
            }
            if (f != null) f.Close();
        }

        public static Grupo Checar(int id) {
            foreach (Grupo g in grupos)
                if (g.Id == id) return g;
            return null;
        }

        public static void Excluir(Grupo g)
        {
            Abrir();
            grupos.Remove(Checar(g.Id));
            Salvar();
        }
        public static void Atualizar(Grupo g)
        {
            Abrir();
            Grupo n = Checar(g.Id);
            n.Descricao = g.Descricao;
            n.Nome = g.Nome;
            Salvar();
        }
    }
}
