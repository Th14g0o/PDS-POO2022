using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace POOzap
{
    internal static class NContato
    {
        private static List<Contato> contatos = new List<Contato>();
        public static List<Contato> Listar()
        {
            return contatos;
        }

        public static void Inserir(Contato c)
        {
            Abrir();
            contatos.Add(c);
        }
        public static void Salvar()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Contato>));
            StreamWriter f = new StreamWriter("./brasil", false);
            x.Serialize(f, contatos);
            f.Close();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Contato>));
                f = new StreamReader("./brasil", false);
                contatos = (List<Contato>)x.Deserialize(f);
            }
            catch
            {
                contatos = new List<Contato>();
            }
            if (f != null)f.Close();
        }

    }
}
