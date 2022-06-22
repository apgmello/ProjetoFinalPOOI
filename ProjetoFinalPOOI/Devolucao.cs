namespace ProjetoFinalPOOI
{
    internal class Devolucao
    {

        private static double valorPagar;
        private static Aluguel aluguel;
        public static void Devolver()
        {
            long cpf;
            do
            {
                Console.Write("Digite o CPF: ");
                if (!long.TryParse(Console.ReadLine(), out cpf) || cpf.ToString().Length < 11)
                {
                    Console.WriteLine("Número inválido");
                }
            } while (cpf.ToString().Length < 11);

            aluguel = Cadastro.BuscarAluguel(cpf);

            if (aluguel == null)
            {
                Console.WriteLine("Aluguel não encontrado!");
            }
            else
            {
                valorPagar = 0;
                aluguel.Cliente.Pontuacao += 50;
                DateOnly dataDevolucao;
                bool dataCerta = false;
                do
                {
                    Console.Write("Data da devolução: ");
                    if (!DateOnly.TryParse(Console.ReadLine(), out dataDevolucao) || dataDevolucao < aluguel.DataAluguel)
                    {
                        Console.WriteLine("Data Inválida!");
                    }
                    else
                    {
                        dataCerta = true;
                    }
                } while (dataCerta == false);

                int diasAlugados;
                diasAlugados = dataDevolucao.DayNumber - aluguel.DataAluguel.DayNumber;

                string limpo;
                do
                {
                    Console.Write("Carro limpo (S/N): ");
                    limpo = Console.ReadLine().Trim().ToUpper();
                    if (limpo != "S" && limpo != "N")
                    {
                        Console.WriteLine("Resposta inválida!");
                    }
                } while (limpo != "S" && limpo != "N");
                if (limpo == "N")
                {
                    valorPagar += 50;
                }
                string batido;
                do
                {
                    Console.Write("Carro Batido (S/N): ");
                    batido = Console.ReadLine().Trim().ToUpper();
                    if (batido != "S" && batido != "N")
                    {
                        Console.WriteLine("Resposta inválida!");
                    }
                } while (batido != "S" && batido != "N");
                if (batido == "S")
                {
                    valorPagar += 500;
                }
                string perdaTotal;
                do
                {
                    Console.Write("Perda Total (S/N): ");
                    perdaTotal = Console.ReadLine().Trim().ToUpper();
                    if (perdaTotal != "S" && perdaTotal != "N")
                    {
                        Console.WriteLine("Resposta inválida!");
                    }
                } while (perdaTotal != "S" && perdaTotal != "N");
                if (perdaTotal == "S")
                {
                    valorPagar += 2000;
                }
                string desconto; ;
                if (aluguel.Cliente.Pontuacao >= 300)
                {
                    valorPagar += diasAlugados * aluguel.Carro.ValorCategoria;
                    valorPagar = valorPagar / 2;
                    desconto = "50%";
                }
                else
                {
                    valorPagar += diasAlugados * aluguel.Carro.ValorCategoria;
                    desconto = "0%";
                }
                aluguel.Carro.Alugado = false;
                Cadastro.RemoverAluguel(aluguel);
                Console.WriteLine($"Aluguel do {aluguel.Carro.Modelo} para o cliente {aluguel.Cliente.Nome} finalizado!");
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Aluguel de carros Lets'Carros");
                Console.WriteLine($"Atendente: {Cadastro.FuncionarioAtual.Nome}");
                Console.WriteLine($"Cliente: {aluguel.Cliente.Nome}");
                Console.WriteLine($"Pontuação: {aluguel.Cliente.Pontuacao}");
                Console.WriteLine($"Desconto: {desconto}");
                Console.WriteLine($"Caro limpo: {limpo}");
                Console.WriteLine($"Carro batido: {batido}");
                Console.WriteLine($"Perda total: {perdaTotal}");
                Console.WriteLine($"Safra Seguros");
                Console.WriteLine($"Valor a Pagar: {valorPagar:C2}");
                Console.WriteLine("-------------------------");
            }
        }
    }
}

