using ByteBank.Sistemas;
using System;

namespace ByteBank.Funcionarios
{
    internal class Diretor : Autenticavel
    {
        public Diretor(string cpf) : base(5000,cpf)
        {
            Console.WriteLine("Criando Diretor");
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;

        }
        public override double GetBonificacao()
        {
            return Salario + 0.5;
                ;
        }

    }
}