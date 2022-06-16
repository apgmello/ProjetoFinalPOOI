namespace ProjetoFinalPOOI
{
    public class CartaoCredito
    {
        public long nºCartaoCredito { get; set; }     

        public string DataValidade { get; set; }  


        public string? NomeCartao { get; set; }

    public void AlterarCadastrao()
        {
            Console.WriteLine("Insira o novo número do cartão");
            nºCartaoCredito = long.Parse(Console.ReadLine());

            Console.WriteLine("Insira a data de validade do cartão");
            DataValidade = Console.ReadLine();
          

            Console.WriteLine("Insira o nome escrito no cartão");
            NomeCartao = Console.ReadLine();
        }

    }
}
