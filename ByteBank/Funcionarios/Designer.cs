﻿using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Designer : FuncionarioAutenticavel
    {
        public Designer(string cpf) : base(1000,cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
