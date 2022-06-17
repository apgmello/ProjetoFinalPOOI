
using ProjetoFinalPOOI;

Cadastro.Inicializar();
Funcionario funcionario;

Console.WriteLine("Lets'Carros");
do
{
    Console.WriteLine("Entre com o funcionário");
    var cpf = Pessoa.LerCpf();
    funcionario = Cadastro.BuscarFuncionario(cpf);
    if (funcionario == null)
    {
        Console.WriteLine("Funcionario não encontrado!");
    }
} while (funcionario == null);
Console.WriteLine($"Bem vindo(a) {funcionario.Nome}");
Cadastro.FuncionarioAtual = funcionario;
Console.Clear();

var testeplacas = new List<string> { "AAA1111", "BBB2222", "CCC3333", "DDD4444" }; //remover após substituir por banco de dados
int opcao;
bool valido = true;

do
{
    Console.WriteLine("||----------------------------------||\n" +
                      "||            Lets'Carros           ||\n" +
                      "||----------------------------------||\n" +
                      "||Digite o índice da opção desejada:||\n" +
                      "||----------------------------------||\n" +
                      "||(1) Cadastrar cliente             ||\n" +
                      "||(2) Cadastrar Carro               ||\n" +
                      "||(3) Alugar ou devolver carro      ||\n" +
                      "||(4) Sair                          ||\n" +
                      "||__________________________________||\n");
    Console.Write("Opção: ");

    valido = int.TryParse(Console.ReadLine(), out opcao);

    switch (opcao)
    {
        case 1:
            opcao = 0;
            Console.Clear();
            Console.WriteLine("Cadastro de Cliente:\n");
            var pessoa = Cliente.Ler();
            break;
        case 2:
            opcao = 0;
            Console.Clear();
            Console.WriteLine("Cadastro de Veículo:");
            var carro = Carro.Ler(testeplacas); // substituir testeplacas por banco de dados
            carro.DadosV();
            Console.WriteLine("\nVeículo Cadastrado com sucesso!\n");
            Console.ReadKey();
            Console.Clear();

            break;
        case 3:
            opcao = 0;
            Console.Clear();
            do
            {
                
                Console.WriteLine("||----------------------------------||\n" +
                                  "||     Alugar ou devolver carro     ||\n" +
                                  "||----------------------------------||\n" +
                                  "||Digite o índice da opção desejada:||\n" +
                                  "||----------------------------------||\n" +
                                  "||(1) Alugar                        ||\n" +
                                  "||(2) Devolver                      ||\n" +
                                  "||(3) Retornar ao menu anterior     ||\n" +
                                  "||__________________________________||\n");
                Console.Write("Opção: ");
                valido = int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        opcao = 0;
                        Console.Clear();
                        Console.WriteLine("Alugar carro:\n");
                        Aluguel.Alugar();

                        //Inserir forma de alugar carro
                        Console.WriteLine("\nVeículo Alugado com sucesso!\n");
                        break;
                    case 2:
                        opcao = 0;
                        Console.Clear();
                        Console.WriteLine("Devolver carro:\n");

                        Devolucao.Devolver();
                        // Inserir forma de devolver carro

                        Console.WriteLine("\nVeículo Retornado com sucesso!\n");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.\n");
                        valido = false;
                        break;

                }
            } while (!valido || opcao != 3);
            break;
        case 4:
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente.\n");
            valido = false;
            break;

    }

} while (!valido || opcao != 4);

Console.WriteLine("\nObrigado por utilizar a Lets' Carros, volte sempre!");


