using POO.Entities.Enums;

namespace POO.Entities
{
    public abstract class Conta
    {
        public Conta()
        {
            NumeroDaConta = Guid.NewGuid();
            Saldo = 0;
        }

        #region [Propriedades]    
        private Guid NumeroDaConta { get; set; }
        public int Saldo { get; protected set; }
        public TipoDeConta TipoDeConta { get; set; }
        public abstract int AplicaJuros { get; set; }
        public Cliente Cliente { get; set; }
        #endregion

        public Guid RetornarNumeroConta()
        {
            return NumeroDaConta;
        }

        #region [Contratos] 
        public abstract void Depositar(int valor);

        public abstract void Sacar(int valor);

        public abstract void Transferir(Conta contaDestino, int valor);

        #endregion


    }

}
