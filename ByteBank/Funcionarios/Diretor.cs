using System;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(5000,cpf)
        {
            Console.WriteLine("Criando Diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;

        }
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao()
                ;
        }

    }
}