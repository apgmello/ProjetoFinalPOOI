namespace ProjetoFinalPOOI
{
    public class CartaoCredito
    {
        public long Numero { get; set; }

        public int DataValidade { get; set; }

        public string? NomeCartao { get; set; }

        public CartaoCredito(long numero, int dataValidade, string nomeCartao)
        {
            Numero = numero;
            DataValidade = dataValidade;
            NomeCartao = nomeCartao;
        }

        public static CartaoCredito Ler()
        {
            long numero;
            bool verificador = false;
            do
            {
                Console.Write("Digite o numero do cartão: ");
                numero = long.Parse(Console.ReadLine().Trim());

                if (numero.ToString().Length >= 13 && numero.ToString().Length <= 16)
                {
                    verificador = true;
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }

            } while (!verificador);

            int dataValidade;
            bool verificador2 = false;
            do
            {
                verificador2 = false;
                Console.Write("Digite a data de validade do cartão (mm/aaaa): ");
                dataValidade = int.Parse(Console.ReadLine().Trim().Remove(0, 3));

                if (dataValidade < DateTime.Now.Year)
                {
                    Console.WriteLine("Data inválida ou cartão vencido.");
                    verificador2 = true;
                }

            } while (verificador2);

            string nomeCartao;
            do
            {
                Console.Write("Digite o nome escrito no cartão: ");
                nomeCartao = Console.ReadLine().Trim();
            } while (nomeCartao.Length == 0);


            return new CartaoCredito(numero, dataValidade, nomeCartao);
        }


        public void AlterarCadastro()
        {
            long numero = 0;
            bool verificador = true;
            do
            {
                Console.Write("Digite o número do cartão: ");
                Numero = long.Parse(Console.ReadLine().Trim());

                if (Numero.ToString().Length >= 13 && Numero.ToString().Length <= 16)
                {
                    verificador = true;
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }

            } while (!verificador);

            bool verificador2 = false;
            do
            {
                Console.Write("Digite a data de validade do cartão (mm/aaaa): ");
                DataValidade = int.Parse(Console.ReadLine().Trim().Remove(0, 3));

                if (DataValidade > DateTime.Now.Year)
                {
                    Console.WriteLine("Data inválida ou cartão vencido.");
                    verificador2 = true;
                }
            } while (verificador2);

            do
            {
                Console.Write("Digite o nome escrito no cartão: ");
                NomeCartao = Console.ReadLine().Trim();
            } while (NomeCartao.Length == 0);


        }

    }
}
