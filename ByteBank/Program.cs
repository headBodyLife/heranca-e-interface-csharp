using System;
using System.Runtime.InteropServices;
using ByteBank.Funcionarios;
namespace ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            
            Funcionario funcionario1 = new Funcionario(2000,"312.454.677-22");
            funcionario1.Nome = "Carlos";
            Console.WriteLine(funcionario1.CPF);
            Console.WriteLine("Total de Funcionarios: "+Funcionario.TotalDeFuncionarios);

            Console.WriteLine("Salario de Carlos "+funcionario1.Salario);
            funcionario1.AumentarSalario();
            Console.WriteLine("Novo salário de Carlos " + funcionario1.Salario);

            gerenciador.Registrar(funcionario1);


            Diretor funcionario2 = new Diretor("546-421-435-56");
            funcionario2.Nome = "Roberta";
            Console.WriteLine(funcionario2.CPF);
            Console.WriteLine("Total de Funcionarios: "+Funcionario.TotalDeFuncionarios);


            Funcionario funcionario2Teste = funcionario2;
            Console.WriteLine("Salario de Roberta " + funcionario2.Salario);

            funcionario2.AumentarSalario();
            Console.WriteLine("Novo salário de Roberta "+ funcionario2.Salario);
            Console.WriteLine("Bonificação de uma referencia de Diretor: " + funcionario2.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia de Funcionario: "+funcionario2Teste.GetBonificacao());

            gerenciador.Registrar(funcionario2);

            Funcionario funcionario3 = new Diretor("545.545.767-55");
            funcionario3.Nome = "Pedro";
            
            
            //double totalBonificacoes = funcionario1.GetBonificacao();

            Console.WriteLine(funcionario1.Nome);
            Console.WriteLine(funcionario1.GetBonificacao());

            
            Console.WriteLine(funcionario2.Nome);
            Console.WriteLine(funcionario2.GetBonificacao());
            
            Console.WriteLine("Total de bonificação : "+gerenciador.GetTotalBeneficacao());

            Console.ReadLine();
        }
    }
}