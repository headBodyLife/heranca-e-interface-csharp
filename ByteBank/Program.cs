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
            
            Funcionario funcionario1 = new Funcionario("312.454.677-22");
            funcionario1.Nome = "Carlos";
            funcionario1.Salario = 4800;
            gerenciador.Registrar(funcionario1);

            Console.WriteLine("Total de Funcionarios: "+Funcionario.TotalDeFuncionarios);
            
            Diretor funcionario2 = new Diretor("546-421-435-56");
            funcionario2.Nome = "Roberta";
            funcionario2.Salario = 5000;
            gerenciador.Registrar(funcionario2);

            Console.WriteLine("Total de Funcionarios: "+Funcionario.TotalDeFuncionarios);

            Funcionario funcionario2Teste = funcionario2;
            Console.WriteLine("Bonificação de uma referencia de Diretor: "+funcionario2.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia de Funcionario: "+funcionario2Teste.GetBonificacao());
            
            Funcionario funcionario3 = new Diretor("545.545.767-55");
            funcionario3.Nome = "Pedro";
            
            
            //double totalBonificacoes = funcionario1.GetBonificacao();

            Console.WriteLine(funcionario1.Nome);
            Console.WriteLine(funcionario1.GetBonificacao());

            
            Console.WriteLine(funcionario2.Nome);
            Console.WriteLine(funcionario2.GetBonificacao());
            
            Console.WriteLine("Total de bonificação : "+gerenciador.GetTotalBeneficacao());


        }
    }
}