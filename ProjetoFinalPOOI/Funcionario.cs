namespace ProjetoFinalPOOI
{
    internal class Funcionario : Pessoa
    {
        public long CarteiraTrabalho { get; }
        public string Cargo { get; }

        public Funcionario(string nome, DateOnly dataNascimento, long cpf, string endereco, string telefone, long cnh, long carteiraTrabalho, string cargo) : base(nome, dataNascimento, cpf, endereco, telefone, cnh)
        {
            CarteiraTrabalho = carteiraTrabalho;
            Cargo = cargo;
        }
    }
}
