﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOzap
{
    public class Grupo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int IdMembro { get; set;}
        public override string ToString()
        {
            return $"[{Id}] {Nome} - {Descricao}";
        }
    }
}
