namespace ProjetoFinalPOOI
{
    public class CartaoCredito
    {
        public long Numero { get; set; }

        public DateOnly? DataValidade { get; set; }

        public string? NomeCartao { get; set; }

        public CartaoCredito(long numero, DateOnly dataValidade, string nomeCartao)
        {
            Numero = numero;
            DataValidade = dataValidade;
            NomeCartao = nomeCartao;
        }

        public static CartaoCredito Ler()
        {
            long numero = 0;
            bool verificador = false;
            do
            {
                Console.Write("Digite o numero do cartão");
                numero = long.Parse(Console.ReadLine().Trim());

                if (numero > 13 && numero < 16)
                {
                    verificador = true;
                }

            } while (verificador);

            DateOnly dataValidade;
            bool verificador2 = false;
            do
            {
                Console.Write("Digite a data de validade do cartão");
                dataValidade = DateOnly.Parse(Console.ReadLine());

                if (dataValidade.Year > DateTime.Now.Year)
                {
                    verificador2 = true;
                }
            } while (verificador2);

            string nomeCartao;
            do
            {
                Console.WriteLine("Digite o nome escrito no cartão");
                nomeCartao = Console.ReadLine().Trim();
            }while(nomeCartao.Length == 0);


            return new CartaoCredito(numero, dataValidade, nomeCartao);
        }


        public void AlterarCadastro()
        {
            long numero = 0;
            bool verificador = true;
            do
            {
                Console.Write("Digite o número do cartão");
                Numero = long.Parse(Console.ReadLine().Trim());

                if (Numero > 13 && Numero < 16)
                {
                    verificador = false;
                }

            } while (verificador);

            bool verificador2 = false;
            do
            {
                Console.Write("Digite a data de validade do cartão");
                DataValidade = DateOnly.Parse(Console.ReadLine());

                if (DataValidade.Value.Year > DateTime.Now.Year)
                {
                    verificador2 = true;
                }
            } while (verificador2);

            do
            {
                Console.Write("Digite o nome escrito no cartão");
                NomeCartao = Console.ReadLine().Trim();
            } while (NomeCartao.Length == 0);


        }

    }
}
