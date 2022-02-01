using System;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        public Funcionario(string cpf)
        {
            Console.WriteLine("Criando Funcionario");
            CPF = cpf;
            TotalDeFuncionarios++;
        }
       
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
        
    }
}