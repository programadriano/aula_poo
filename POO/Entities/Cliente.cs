namespace POO.Entities
{
    public class Cliente
    {
        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;          
        }

        #region [propriedades]
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        #endregion

    }
}
