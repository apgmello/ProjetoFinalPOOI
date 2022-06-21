namespace ProjetoFinalPOOI
{
    internal class Cliente : Pessoa
    {
        public int Pontuacao { get; set; } = 100;
        public string Obs { get; }
        public CartaoCredito CartaoCredito { get; }
        public Cliente(string nome, DateOnly dataNascimento, long cpf, string endereco, string telefone, long cnh, string obs, CartaoCredito cartaoCredito) : base(nome, dataNascimento, cpf, endereco, telefone, cnh)
        {
            this.Obs = obs;
            CartaoCredito = cartaoCredito;
        }
        public static new Cliente Ler(long cpf)
        {
            var pessoa = Pessoa.Ler(cpf);
            var obs = LerObs();
            var cartao = CartaoCredito.Ler();
            return new Cliente(pessoa.Nome, pessoa.DataNascimento, pessoa.Cpf, pessoa.Endereco, pessoa.Telefone, pessoa.Cnh, obs, cartao);
        }
        private static string LerObs()
        {
            Console.Write("Observação: ");
            return Console.ReadLine();
        }
        public void DadosC()
        {
            Console.Write("\nDados do Cliente");
            Console.Write("\n-------------------------------------------");
            Console.Write("\nNome do Cliente: " + Nome);
            Console.Write("\nData de nascimento: " + DataNascimento);
            Console.Write("\nCPF: " + Cpf);
            Console.Write("\nEnderço: " + Endereco);
            Console.Write("\nTelefone: " + Telefone);
            Console.Write("\nCNH: " + Cnh);
            Console.Write("\nNúmero do cartão de crédito: " + CartaoCredito.Numero);
            Console.Write("\nData de validade do cartão: " + CartaoCredito.DataValidade);
            Console.Write("\nNome no cartão: " + CartaoCredito.NomeCartao);

        }
    }
}
