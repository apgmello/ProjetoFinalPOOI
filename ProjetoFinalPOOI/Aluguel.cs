namespace ProjetoFinalPOOI
{
    internal class Aluguel
    {
        public Cliente Cliente { get; }
        public Carro Carro { get; }
        public DateOnly DataAluguel { get; }

        public Aluguel(Cliente cliente, Carro carro)
        {
            Cliente = cliente;
            Carro = carro;
            var hoje = DateTime.Now;
            DataAluguel = new DateOnly(hoje.Year, hoje.Month, hoje.Day);
        }
        public static void Alugar()
        {
            Cliente cliente;

            var cpf = Pessoa.LerCpf();

            cliente = Cadastro.BuscarCliente(cpf);
            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado!");
                return;
            }

            if (Cadastro.BuscarAluguel(cliente.Cpf) != null)
            {
                Console.WriteLine($"Cliente {cliente.Nome} já possui um aluguel ativo!");
                return;
            }

            Console.Clear();

            Console.WriteLine($"Novo aluguel para {cliente.Nome}.");
            Console.WriteLine("----------------------------------");
            Cadastro.ListarCarrosDisponiveis();
            Carro carro;

            do
            {
                Console.WriteLine("-------------------------------");
                Console.Write("\nDigite a placa: ");
                var placa = Console.ReadLine();

                carro = Cadastro.BuscarCarro(placa);
                if (carro == null || carro.Alugado)
                {
                    Console.WriteLine("Veículo indisponível!");
                    carro = null;
                }

            } while (carro == null);
            Console.Clear();
            Cadastro.AdicionarAluguel(new Aluguel(cliente, carro));
            carro.Alugado = false;
            Console.WriteLine($"Aluguel do carro {carro.Modelo} confirmado para o cliente {cliente.Nome}.");

        }
    }
}
