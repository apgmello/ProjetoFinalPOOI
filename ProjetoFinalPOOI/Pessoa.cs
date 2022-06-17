namespace ProjetoFinalPOOI
{
    public class Pessoa
    {
        public string Nome { get; }
        public DateOnly DataNascimento { get; }
        public long Cpf { get; }
        public string Endereco { get; }
        public string Telefone { get; }
        public long Cnh { get; }

        public Pessoa(string nome, DateOnly dataNascimento, long cpf, string endereco, string telefone, long cnh)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Endereco = endereco;
            Telefone = telefone;
            Cnh = cnh;
        }
        public static Pessoa Ler()
        {
            string nome = LerNome();
            DateOnly dataNascimento = LerDataNascimento();
            long cpf = LerCpf();
            string endereco = LerEndereco();
            string telefone = LerTelefone();
            long cnh = LerCnh();
            return new Pessoa(nome, dataNascimento, cpf, endereco, telefone, cnh); //retorna uma instancia de Pessoa
        }
        private static DateOnly LerDataNascimento()
        {
            DateOnly dataNascimento;
            do
            {
                Console.Write("Data de nascimento dd/mm/aaaa: ");
                if (!DateOnly.TryParse(Console.ReadLine(), out dataNascimento) || dataNascimento > new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day))
                {
                    Console.WriteLine("Data inválida!");
                }
            } while (dataNascimento > new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
            return dataNascimento;
        }
        private static long LerCnh()
        {
            long numero;
            string documento;
            do
            {
                Console.Write("CNH somente números: ");
                documento = Console.ReadLine();
                if (!long.TryParse(documento, out numero))
                {
                    Console.WriteLine("Número inválido");
                }
            } while (documento.Length < 11);

            return numero;
        }
        private static string LerTelefone()
        {
            int telefone;
            string formato;
            do
            {
                Console.Write("Telefone somente números: ");
                formato = Console.ReadLine();
                if (!int.TryParse(formato, out telefone))
                {
                    Console.WriteLine("Telefone inválido");
                }
            } while (formato.Length < 11);
            formato.Insert(0, "(");
            formato.Insert(3, ")");
            formato.Insert(9, "-");

            return formato;
        }
        private static string LerEndereco()
        {
            string endereco;
            string[] palavras;
            do
            {
                Console.Write("Endereço: ");
                endereco = Console.ReadLine();
                palavras = endereco.Trim().Split(" ");
                if (palavras.Length < 2)
                {
                    Console.WriteLine("Campo obrigatório!");
                }
            } while (palavras.Length < 2);

            return endereco;
        }
        public static long LerCpf()
        {
            long numero;
            do
            {
                Console.Write("CPF somente números: ");
                if (!long.TryParse(Console.ReadLine(), out numero) || numero.ToString().Length < 11)
                {
                    Console.WriteLine("Número inválido");
                }
            } while (numero.ToString().Length < 11);

            return numero;
        }
        private static string LerNome()
        {
            string? nome;
            string[] palavras;
            do
            {
                Console.Write("Nome completo: ");
                nome = Console.ReadLine();
                palavras = nome.Trim().Split(" ");
                if (palavras.Length < 2)
                {
                    Console.WriteLine("O campo nome deve conter nome e sobrenome!");
                }
            } while (palavras.Length < 2);

            return nome;
        }
    }
}

