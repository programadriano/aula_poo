namespace POO.Entities
{
    public class ContaPJ : Conta
    {
        public override int AplicaJuros { get; set; } = 10;

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
