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
            Abrir();
            return contatos;
        }

        public static void Inserir(Contato c)
        {
            Abrir();
            if (Checar(c.Id) == null)
            {
                contatos.Add(c);
                Salvar();
            }
        }
        public static void Salvar()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Contato>));
            StreamWriter f = new StreamWriter("./contato.xml", false);
            x.Serialize(f, contatos);
            f.Close();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Contato>));
                f = new StreamReader("./contato.xml");
                contatos = (List<Contato>)x.Deserialize(f);
            }
            catch
            {
                contatos = new List<Contato>();
            }
            if (f != null) f.Close();
        }

        public static Contato Checar(int id)
        {
            foreach (Contato c in contatos)
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public static void Excluir(Contato c)
        {
            Abrir();
            contatos.Remove(Checar(c.Id));
            Salvar();
        }

        public static void Atualizar(Contato c)
        {
            Abrir();
            Contato obj = Checar(c.Id);
            if (obj != null)
            {
                obj.Nome = c.Nome;
                obj.Recado = c.Recado;
                obj.Telefone = c.Telefone;
                Salvar();
            }
        }


    }
}