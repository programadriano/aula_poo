using POO.Entities;

namespace POO.Extensions
{
    public static class ContaExtension
    {
        public static int VerificaSaldoFuturo(this Conta conta)
        {
            return conta.Saldo;
        }
    }
}
