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
        public static Membro Checar(Membro x)
        {
            foreach (Membro m in membros)
                if (m.IdContato == x.IdContato && x.IdGrupo ==m.IdGrupo) return m;
            return null;
        }
        public static Membro Checar(Contato c)
        {
            foreach (Membro m in membros)
                if (m.IdContato == c.Id) return m;
            return null;
        }
        public static Membro Checar(Grupo g)
        {
            foreach (Membro m in membros)
                if (m.IdGrupo == g.Id) return m;
            return null;
        }
        public static void Atualizar(Membro m)
        {
            Abrir();
            Membro obj = Checar(m);
            obj.Adm = m.Adm;
            obj.IdGrupo = m.IdGrupo;
            obj.IdContato = m.IdContato;
            Salvar();
        }
        public static void Excluir(Contato c)
        {
            Abrir();
            Membro m = Checar(c);
            membros.Remove(Checar(m));
            Salvar();
        }
        public static void Excluir(Grupo g)
        {
            Abrir();
            Membro m = Checar(g);
            membros.Remove(Checar(m));
            Salvar();
        }

        public static void Adicionar(Contato c, Grupo g)
        {
            
            Membro m = new Membro { IdContato = c.Id, IdGrupo = g.Id, Adm = false};
            int n = 0;
            foreach (Membro x in membros)
            {
                if (m.IdContato == x.IdContato && m.IdGrupo == x.IdGrupo
                    )
                {
                    n++;
                    break;
                }
            }
            if (n == 0)
            {
                Abrir();
                Inserir(m);
                Salvar();
            }
        }
        public static List<Contato> Listar(Grupo g)
        {
            Abrir();
            List<Contato> cs = new List<Contato>();
            List<Membro> ms = new List<Membro>();

            foreach (Membro m in membros)
                if (m.IdGrupo == g.Id) ms.Add(m);

            foreach (Contato c in NContato.Listar())
            {
                foreach (Membro m in ms)
                {
                    if (m.IdContato == c.Id && cs.IndexOf(c) == -1)
                    {
                        cs.Add(c);
                    }
                }
            }
            return cs;
        }
        public static List<Membro> Adms(Grupo g)
        {
            Abrir();
            List<Membro> ms = new List<Membro>();
            foreach (Contato c in Listar(g))
            {
                foreach (Membro m in membros)
                {
                    if (c.Id == m.IdContato && g.Id == m.IdGrupo && ms.IndexOf(m) == -1)
                        ms.Add(m);
                }
            }      
            return ms;
        }
        public static List<Grupo> Listar(Contato c)
        {
            Abrir();
            List<Grupo> gs = new List<Grupo>();
            foreach (Membro m in membros)
            {
                foreach (Grupo g in NGrupo.Listar())
                {
                    if (m.IdGrupo == g.Id && m.IdContato == c.Id) gs.Add(g);
                }
            }
            
            return gs;
        }

        public static void Promover(Contato c, Grupo g)
        {
            Abrir();
            foreach (Membro m in membros)
            {
                if (c.Id == m.IdContato && g.Id == m.IdGrupo)
                {
                    m.Adm = true;
                    Atualizar(m);
                }
            }

        }
        public static void Rebaixar (Contato c, Grupo g)
        {
            Abrir();
            foreach (Membro m in membros)
            {
                if (c.Id == m.IdContato && g.Id == m.IdGrupo)
                {
                    m.Adm = false;
                    Atualizar(m);
                }
            }
        }

    }
}
