namespace ProjetoFinalPOOI
{
    public class Carro
    {
        public string Placa;
        public string Categoria;
        public int ValorCategoria;
        public const int a = 60;
        public const int b = 70;
        public const int c = 80;
        public int Ano;
        public long Km;
        public string Modelo;
        public bool alugado = false;


        public Carro(string placa,string categoria, int ano, long km, string modelo, bool alugado)

        {
            Placa = placa;
            Categoria = AtribuiValorCategoria(categoria);
            //ValorCategoria = valorCategoria;
            Ano = ano;
            Km = km;
            Modelo = modelo;
            alugado = alugado;

        }

        public string AtribuiValorCategoria(string categoria)
        {
            if (categoria == "a")
            {
                ValorCategoria =a;
            }
            else if (categoria == "b")
            {
                ValorCategoria = b;
            }
            else if (categoria == "c")
            {
                ValorCategoria =c;
            }
            else
            {
                ValorCategoria = 0;//Para destacar erro
            }
            return categoria;
        }
        public void DadosV()
        {
            Console.WriteLine("Dados do Carro:");
            Console.WriteLine("Placa: "+Placa);
            Console.WriteLine("Categoria: "+Categoria);
            Console.WriteLine("Valor da Categoria" + ValorCategoria);
            Console.WriteLine("Ano: "+ Ano);
            Console.WriteLine("Kilometragem: "+Km);
            Console.WriteLine("Modelo: "+Modelo);
            Console.WriteLine("Alugado: "+ (alugado ? "Sim" : "Não"));

        }
    }

}
