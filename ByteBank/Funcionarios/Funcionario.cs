namespace ByteBank.Funcionarios
{
    public class Funcionario
    {

        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

     
       
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
        
    }
}