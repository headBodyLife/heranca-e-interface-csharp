using System;
using System.Runtime.InteropServices;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //CalculaBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("222.222.222-22");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerendeDeConta camila = new GerendeDeConta("444.444.444-44");
            camila.Nome = "Camila";
            camila.Senha = "123";


            Console.WriteLine("Nome: " + roberta.Nome);
            sistemaInterno.Logar(roberta, "123");

            Console.WriteLine("Nome: " + camila.Nome);
            sistemaInterno.Logar(camila, "1234");


    


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

            Desenvolvedor guilherme = new Desenvolvedor("555.555.555-55");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificação do mês " +
                gerenciadorBonificacao.GetTotalBeneficacao());

        }
    }
}