using System;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public Funcionario(double salario,string cpf)
        {
            Console.WriteLine("Criando Funcionario");
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionarios++;
        }
       
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
        
    }
}