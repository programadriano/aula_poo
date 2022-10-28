using POO.Entities.Enums;

namespace POO.Entities
{
    public class Conta
    {
        public Conta(string nome)
        {
            Nome = nome;
            NumeroDaConta = Guid.NewGuid();
            Saldo = 0;
        }


        #region [Propriedades]    
        public string Nome { get; set; }
        private Guid NumeroDaConta { get; set; }
        public int Saldo { get; private set; }
        public TipoDeConta TipoDeConta { get; set; }

        #endregion

        #region [Metodos] 
        public Guid RetornarNumeroConta()
        {
            return NumeroDaConta;
        }

        public void Depositar(int valor)
        {
            Saldo += valor;
            // return $"Valor {valor} depositado com sucesso!";
        }

        public void Sacar(int valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
            }
        }

        public void Transferir(Conta contaDestino, int valor)
        {

            if (Saldo > valor)
            {
                Saldo -= valor;
                contaDestino.Depositar(valor);
            }


        }
        #endregion

    }
}
