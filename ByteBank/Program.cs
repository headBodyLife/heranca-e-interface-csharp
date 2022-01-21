﻿using System;
using System.Runtime.InteropServices;
using ByteBank.Funcionarios;
namespace ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            
            Funcionario funcionario1 = new Funcionario(1);
            funcionario1.Nome = "Carlos";
            funcionario1.CPF = "312.454.677-22";
            funcionario1.Salario = 4800;
            gerenciador.Registrar(funcionario1);

            Diretor funcionario2 = new Diretor();
            funcionario2.Nome = "Roberta";
            funcionario2.CPF = "546-421-435-56";
            funcionario2.Salario = 5000;
            gerenciador.Registrar(funcionario2);

            //double totalBonificacoes = funcionario1.GetBonificacao();

            Console.WriteLine(funcionario1.Nome);
            Console.WriteLine(funcionario1.GetBonificacao());

            
            Console.WriteLine(funcionario2.Nome);
            Console.WriteLine(funcionario2.GetBonificacao());
            
            Console.WriteLine("Total de bonificação : "+gerenciador.GetTotalBeneficacao());


        }
    }
}