using System;
using ByteBank.Funcionarios;
namespace ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario(1);
            funcionario1.Nome = "Carlos";
            funcionario1.CPF = "312.454.677-22";
            funcionario1.Salario = 4800;

            Console.WriteLine(funcionario1.Nome);
            Console.WriteLine(funcionario1.GetBonificacao());


        }
    }
}