namespace POO.Entities
{
    public class ContaPF : Conta
    {
        public override int AplicaJuros { get; set; } = 3;

        public override void Depositar(int valor)
        {
            Saldo += valor;
        }

        public override void Sacar(int valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
            }
            else
            {
                Saldo -= valor;
                Saldo -= AplicaJuros;
            }          
                        
          
        }

        public override void Transferir(Conta contaDestino, int valor)
        {
            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}
