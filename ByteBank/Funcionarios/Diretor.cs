using System;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("Criando Diretor");
        }
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao()
                ;
        }

    }
}