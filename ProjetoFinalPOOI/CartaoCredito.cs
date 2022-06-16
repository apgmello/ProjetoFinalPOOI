namespace ProjetoFinalPOOI
{
    public class CartaoCredito
    {
        public long Numero { get; set; }     

        public string? DataValidade { get; set; }  

        public string? NomeCartao { get; set; }

    public CartaoCredito(long pNºCartaoCredito, string pDataValidade, string pNomeCartao)
        {
            Numero = pNºCartaoCredito;
            DataValidade = pDataValidade; ;
            this.NomeCartao = pNomeCartao;
        }

    public void AlterarCadastrao()
        {
            Console.WriteLine("Insira o novo número do cartão");
            Numero = long.Parse(Console.ReadLine());

            Console.WriteLine("Insira a data de validade do cartão");
            DataValidade = Console.ReadLine();
          
            Console.WriteLine("Insira o nome escrito no cartão");
            NomeCartao = Console.ReadLine();
        }

    }
}
