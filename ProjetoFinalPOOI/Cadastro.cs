namespace ProjetoFinalPOOI
{
    internal static class Cadastro
    {
        public static Funcionario FuncionarioAtual { get; set; }

        public static List<Carro> Carros { get; } = new List<Carro>();
        public static List<Cliente> Clientes { get; } = new List<Cliente>();
        public static List<Aluguel> Alugueis { get; } = new List<Aluguel>();
        public static List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
        //----------------------------------
        public static void Inicializar()
        {
            InicializarFuncionarios();
            InicializarCarros();
            InicializarClientes();
        }
        //----------------------------------
        private static void InicializarFuncionarios()
        {
            Funcionarios.Add(new Funcionario("Ana Mello", new DateOnly(1992, 10, 29), 12345678901, "São Paulo", "(11)99999-9999", 111111111111, 258963, "Atendente"));
            Funcionarios.Add(new Funcionario("André", new DateOnly(1992, 10, 29), 12345678902, "São Paulo", "(11)99999-9999", 111111111111, 258963, "Atendente"));
            Funcionarios.Add(new Funcionario("Edu", new DateOnly(1992, 10, 29), 12345678903, "São Paulo", "(11)99999-9999", 111111111111, 258963, "Atendente"));
        }
        public static Funcionario BuscarFuncionario(long cpf)
        {
            foreach (var funcionario in Funcionarios)
            {
                if (funcionario.Cpf == cpf)
                {
                    return funcionario;
                }
            }
            return null;
        }
        //----------------------------------
        private static void InicializarCarros()
        {
            AdicionarCarro(new Carro("xxx0000", "A", 2021, 27, "Renault Kwid", false));
            AdicionarCarro(new Carro("xxx1111", "A", 2020, 1000, "Renault Kwid", false));
            AdicionarCarro(new Carro("xxx2222", "B", 2020, 10000, "Jeep Renegade", false));
            AdicionarCarro(new Carro("xxx3333", "B", 2021, 300, "Jeep Renegade", false));
            AdicionarCarro(new Carro("xxx4444", "C", 2021, 250, "Citroen C4 Cactus", false));
            AdicionarCarro(new Carro("xxx5555", "C", 2020, 5000, "Citroen C4 Cactus", false));
        }
        public static void AdicionarCarro(Carro carro)
        {
            Carros.Add(carro);
        }
        public static Carro BuscarCarro(string placa)
        {
            foreach (var carro in Carros)
            {
                if (carro.Placa == placa)
                {
                    return carro;
                }
            }
            return null;
        }
        public static void ListarCarrosDisponiveis()
        {
            Console.WriteLine("Carros Disponíveis");
            foreach (var carro in Carros)
            {
                if (carro.Alugado == false)
                {
                    Console.WriteLine("-------------------------------");
                    carro.DadosV();
                }
            }
        }
        //----------------------------------
        private static void InicializarClientes()
        {
            AdicionarCliente(new Cliente("Amanda Mantovani", new DateOnly(1990, 03, 15), 12345678904, "Rua x, 1157, Bairro J, São Paulo", "(11)99999-4444", 12345678910, " ", new CartaoCredito(1234567890123, 2029, "Amanda M")));
            AdicionarCliente(new Cliente("Michael Tadeu", new DateOnly(1988, 05, 20), 12345678905, "Rua y, 1157, Bairro D, São Paulo", "(11)99999-5555", 12345678911, " ", new CartaoCredito(1234567890563, 2029, "Michael T")));
        }
        public static void AdicionarCliente(Cliente cliente)
        {
            if (BuscarCliente(cliente.Cpf) != null)
            {
                Console.WriteLine("Cliente já cadastrado!");
                return;
            }

            Clientes.Add(cliente);
        }
        public static Cliente BuscarCliente(long cpf)
        {
            foreach (var cliente in Clientes)
            {
                if (cliente.Cpf == cpf)
                {
                    return cliente;
                }
            }
            return null;
        }

        //----------------------------------
        public static void AdicionarAluguel(Aluguel aluguel)
        {
            Alugueis.Add(aluguel);
        }
        public static Aluguel BuscarAluguel(long cpf)
        {
            foreach (var aluguel in Alugueis)
            {
                if (aluguel.Cliente.Cpf == cpf)
                {
                    return aluguel;
                }
            }

            return null;
        }
        public static void RemoverAluguel(Aluguel aluguel)
        {
            Alugueis.Remove(aluguel);
        }
    }
}