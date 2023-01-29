using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Resolvers;

namespace POOzap
{
    internal static class NMembro
    {
        private static List<Membro> membros = new List<Membro>();
        public static void Inserir(Membro m)
        {
            Abrir();
            membros.Add(m);
            Salvar();
        }
        public static List<Membro> Listar()
        {
            Abrir();
            return membros;
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Membro>));
            StreamWriter f = new StreamWriter("./membros.xml", false);
            xml.Serialize(f, membros);
            f.Close();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Membro>));
                f = new StreamReader("./membros.xml");
                membros = (List<Membro>) xml.Deserialize(f);
            }
            catch
            {
                membros = new List<Membro>();
            }
            if (f != null) f.Close();
        }
        public static Membro Checar(int id)
        {
            foreach (Membro m in membros)
                if (m.Id == id) return m;
            return null;
        }
        public static void Atualizar(Membro m)
        {
            Abrir();
            Membro obj = Checar(m.Id);
            obj.Adm = m.Adm;
            obj.IdGrupo = m.IdGrupo;
            obj.IdContato = m.IdContato;
            Salvar();
        }
        public static void Excluir(Membro m)
        {
            Abrir();
            membros.Remove(Checar(m.Id));
            Salvar();
        }


        public static void Adicionar(Contato c, Grupo g)
        {
            Membro m = new Membro { IdContato = c.Id, IdGrupo = g.Id, Adm = false};
            NMembro.Inserir(m);     
        }
        public static List<Membro> Listar(Grupo g)
        {
            List<Membro> ms = new List<Membro>();
            foreach (Membro m in Listar())
                if (m.IdGrupo == g.Id) ms.Add(m);
            return ms;
        }
        public static List<Grupo> Listar(Contato c)
        {
            Membro m = new Membro{Id = -1, IdGrupo = -1};
            foreach (Membro obj in Listar())
                if (obj.IdContato == c.Id) m = obj;

            List<Grupo> gs = new List<Grupo>();
            foreach (Grupo g in NGrupo.Listar())
                if (g.Id == m.IdGrupo) gs.Add(g);
            
            return gs;
        }

        public static void Promover(Membro m)
        {
            m.Adm = true;
            Atualizar(m);
        }
        public static void Rebaixar (Membro m)
        {
            m.Adm = false;
            Atualizar(m);
        }

    }
}
