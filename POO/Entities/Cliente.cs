namespace POO.Entities
{
    public class Cliente
    {
        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Conta = new Conta();
        }

        #region [propriedades]
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public Conta Conta { get; set; }
        #endregion

    }
}
