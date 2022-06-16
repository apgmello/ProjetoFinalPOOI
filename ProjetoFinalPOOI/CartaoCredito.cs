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
            long pNumero = 0;
            bool verificador = true;
            while (true)
            {
                Console.Write("Digite o numero do cartão");
                pNumero = long.Parse(Console.ReadLine().Trim());

                if (pNumero > 13 && pNumero < 16)
                {
                    verificador = false;
                }

            }

            Console.Write("Digite a data de validade do cartão");
            string? pDataValidade = Console.ReadLine().Trim();

            Console.WriteLine("Digite o nome escrito no cartão");
            string? pNomeCartao = Console.ReadLine().Trim();

            return new CartaoCredito(pNumero, pDataValidade, pNomeCartao);
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
