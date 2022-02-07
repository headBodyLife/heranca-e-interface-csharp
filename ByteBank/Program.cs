using System;
using System.Runtime.InteropServices;
using ByteBank.Funcionarios;
namespace ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            CalculaBonificacao();
            Console.ReadLine();
        }

        public static void CalculaBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();


            Funcionario pedro = new Designer("111.111.111-11");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("222.222.222-22");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("333.333.333-33");
            igor.Nome = "Igor";

            Funcionario camila = new GerendeDeConta("444.444.444-44");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificação do mês " +
                gerenciadorBonificacao.GetTotalBeneficacao());

        }
    }
}