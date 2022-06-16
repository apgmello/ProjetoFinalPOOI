namespace ProjetoFinalPOOI
{
    public class CartaoCredito
    {
        public long Numero { get; set; }     

        public string? DataValidade { get; set; }  

        public string? NomeCartao { get; set; }

    public CartaoCredito(long numero, string dataValidade, string nomeCartao)
        {
            Numero = numero;
            DataValidade = dataValidade; ;
            NomeCartao = nomeCartao;
        }
    
    public static CartaoCredito Ler()
        {
            long numero = 0;
            bool verificador = true;
            while (true)
            {
                Console.Write("Digite o numero do cartão");
                numero = long.Parse(Console.ReadLine().Trim());

                if (numero > 13 && numero < 16)
                {
                    verificador = false;
                }

            }

            Console.Write("Digite a data de validade do cartão");
            string? dataValidade = Console.ReadLine().Trim();

            Console.WriteLine("Digite o nome escrito no cartão");
            string? nomeCartao = Console.ReadLine().Trim();

            return new CartaoCredito(numero, dataValidade, nomeCartao);
        }


    public void AlterarCadastro()
        {
            Console.Write("Digite o número do cartão");
            Numero = long.Parse(Console.ReadLine().Trim());

            Console.Write("Digite a data de validade do cartão");
            DataValidade = Console.ReadLine().Trim();
          
            Console.Write("Digite o nome escrito no cartão");
            NomeCartao = Console.ReadLine().Trim();
        }

    }
}
