namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        //0 = funcionário
        //1 = diretor
        //2 = designer
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }
       
        public double GetBonificacao()
        {

            return Salario * 0.10;
        }
        
    }
}