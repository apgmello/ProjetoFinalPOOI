namespace ProjetoFinalPOOI
{
    public class Pessoa
    {
        public string Nome { get; }
        DateOnly DataNascimento { get; }
        public long Cpf { get; }
        public long Rg { get; }
        public string Endereco { get; }
        public string Telefone { get; }
        public long Cnh { get; }
        public string Categoria { get; }

        public Pessoa() { }

        public Pessoa(string nome, DateOnly dataNascimento, long cpf, long rg, string endereco, string telefone, long cnh, string categoria)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Rg = rg;
            Endereco = endereco;
            Telefone = telefone;
            Cnh = cnh;
            Categoria = categoria;
        }
        public static Pessoa Ler()
        {
            string nome = LerNome();
            DateOnly dataNascimento = LerDataNascimento();
            long cpf = LerCpf();
            long rg = LerRg();
            string endereco = LerEndereco();
            string telefone = LerTelefone();
            long cnh = LerCnh();
            string categoria = LerCategoria();
            return new Pessoa(nome, dataNascimento, cpf, rg, endereco, telefone, cnh, categoria); //retorna uma instancia de Pessoa
        }

        private static DateOnly LerDataNascimento()
        {
            return new DateOnly();
        }

        private static string LerCategoria()
        {
            return "";
        }

        private static long LerCnh()
        {
            return 0;
        }

        private static string LerTelefone()
        {
            return "";
        }

        private static string LerEndereco()
        {
            return "";
        }

        private static long LerRg()
        {
            return 0;
        }

        private static long LerCpf()
        {
            return 0;
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
