namespace ProjetoFinalPOOI
{
    public class Pessoa
    {
        public string Nome { get; }
        DateOnly DataNascimento { get; }
        public long Cpf { get; }
        public long Rg { get; }
        public string Endereco { get; }
        public long Telefone { get; }
        public long Cnh { get; }
        public string Categoria { get; }

        public Pessoa(string nome, DateOnly dataNascimento, long cpf, long rg, string endereco, long telefone, long cnh, string categoria)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Endereco = endereco;
            Telefone = telefone;
            Cnh = cnh;
            Categoria = categoria;
        }
    }
}
