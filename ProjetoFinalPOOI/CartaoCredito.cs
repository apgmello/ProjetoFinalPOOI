namespace ProjetoFinalPOOI
{
    public class CartaoCredito
    {
        public long Numero { get; set; }     

        public string? DataValidade { get; set; }  

        public string? NomeCartao { get; set; }

    public CartaoCredito(long pNumero, string pDataValidade, string pNomeCartao)
        {
            Numero = pNumero;
            DataValidade = pDataValidade; ;
            NomeCartao = pNomeCartao;
        }
    
    public static CartaoCredito Ler()
        {
            Console.WriteLine("Digite o numero do cartão");
            long pNumero = long.Parse(Console.ReadLine().Trim());

            Console.WriteLine("Digite a data de validade do cartão");
            string? pDataValidade = Console.ReadLine().Trim();

            Console.WriteLine("Digite o nome escrito no cartão");
            string? pNomeCartao = Console.ReadLine().Trim();

            return new CartaoCredito(pNumero, pDataValidade, pNomeCartao);
        }


    public void AlterarCadastro()
        {
            Console.WriteLine("Digite o número do cartão");
            Numero = long.Parse(Console.ReadLine().Trim());

            Console.WriteLine("Digite a data de validade do cartão");
            DataValidade = Console.ReadLine().Trim();
          
            Console.WriteLine("Digite o nome escrito no cartão");
            NomeCartao = Console.ReadLine().Trim();
        }

    }
}
