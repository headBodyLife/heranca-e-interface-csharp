﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public string Nome { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }


    }
}
