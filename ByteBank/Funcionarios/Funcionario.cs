using System;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario 
    {

        public static int TotalDeFuncionarios { get; private set; }
        
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public abstract void AumentarSalario();

        public Funcionario(double salario,string cpf)
        {
            Console.WriteLine("Criando Funcionario");
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionarios++;
        }

    

        public abstract double GetBonificacao();

    }
}