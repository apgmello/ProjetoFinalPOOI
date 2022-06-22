namespace ProjetoFinalPOOI
{
    public class CartaoCredito
    {
        public long Numero { get; set; }

        public string DataValidade { get; set; }

        public string? NomeCartao { get; set; }

        public CartaoCredito(long numero, string dataValidade, string nomeCartao)
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
                verificador = false;
                Console.Write("Digite o número do cartão: ");
                long.TryParse(Console.ReadLine().Trim(), out numero);

                if (numero.ToString().Length < 13 || numero.ToString().Length > 16)
                {
                    Console.WriteLine("Número inválido.");
                    verificador = true;
                }


            } while (verificador);

            string dataValidade;
            bool verificador2 = false;
            do
            {
                verificador2 = false;
                Console.Write("Digite a data de validade do cartão (mm/aaaa): ");
                dataValidade = Console.ReadLine().Trim();
                int anoValidade = int.Parse(dataValidade.Remove(0,3));
                int mesValidade = int.Parse(dataValidade.Remove(2,5));

                if (anoValidade < DateTime.Now.Year)
                {
                    Console.WriteLine("Data inválida ou cartão vencido.");
                    verificador2 = true;
                }
                else if (mesValidade > 12)
                {
                    Console.WriteLine("Data inválida ou cartão vencido.");
                    verificador2 = true;
                }
                else if (anoValidade == DateTime.Now.Year && mesValidade < DateTime.Now.Month)
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
    }
}
