using System;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public string Senha { get; set; }
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