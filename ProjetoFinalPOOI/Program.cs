
using ProjetoFinalPOOI;

Cadastro.Inicializar();
Funcionario funcionario;

Console.WriteLine("||=========================||\n"+
                  "||      LET'S CARROS       ||\n" +
                  "||-------------------------||\n"+
                  "|| Muito mais que um carro ||\n"+
                  "||=========================||\n");

do
{
    Console.WriteLine("Entre com o funcionário: \n");
    var cpf = Pessoa.LerCpf();
    funcionario = Cadastro.BuscarFuncionario(cpf);
    if (funcionario == null)
    {
        Console.Clear();
        Console.WriteLine("Funcionario não encontrado!\n");
    }
} while (funcionario == null);
Console.WriteLine($"\nBem vindo(a) {funcionario.Nome}!");
Cadastro.FuncionarioAtual = funcionario;
Console.ReadKey();
Console.Clear();

int opcao;
bool valido = true;

do
{
    Console.Clear();
    Console.WriteLine("||==================================||\n" +
                      "||           LET'S CARROS           ||\n" +
                      "||----------------------------------||\n" +
                      "||Digite o índice da opção desejada:||\n" +
                      "||----------------------------------||\n" +
                      "||(1) Cadastrar cliente             ||\n" +
                      "||(2) Cadastrar Carro               ||\n" +
                      "||(3) Alugar ou devolver carro      ||\n" +
                      "||(4) Sair                          ||\n" +
                      "||==================================||\n");
    Console.Write("Opção: ");

    valido = int.TryParse(Console.ReadLine(), out opcao);

    switch (opcao)
    {
        case 1:
            opcao = 0;
            Console.Clear();
            Console.WriteLine("Cadastro de Cliente:\n");

            var cpf = Pessoa.LerCpf();
            Console.Clear();

            if(Cadastro.BuscarCliente(cpf) != null)
            {
                Console.WriteLine("Cliente já cadastrado!");
                Cadastro.BuscarCliente(cpf).DadosC();
                Console.ReadKey();
                break;
            }
            var pessoa = Cliente.Ler(cpf);
            Cadastro.AdicionarCliente(pessoa);
            break;
        case 2:
            opcao = 0;
            Console.Clear();
            Console.WriteLine("Cadastro de Veículo:");
            var carro = Carro.Ler(); 
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
                
                Console.WriteLine("||==================================||\n" +
                                  "||     Alugar ou devolver carro     ||\n" +
                                  "||----------------------------------||\n" +
                                  "||Digite o índice da opção desejada:||\n" +
                                  "||----------------------------------||\n" +
                                  "||(1) Alugar                        ||\n" +
                                  "||(2) Devolver                      ||\n" +
                                  "||(3) Retornar ao menu anterior     ||\n" +
                                  "||==================================||\n");
                Console.Write("Opção: ");
                valido = int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        opcao = 0;
                        Console.Clear();
                        Console.WriteLine("Alugar carro:\n");

                        Cadastro.FuncionarioAtual = funcionario;
                        Aluguel.Alugar();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        opcao = 0;
                        Console.Clear();
                        Console.WriteLine("Devolver carro:\n");

                        Cadastro.FuncionarioAtual = funcionario;
                        Devolucao.Devolver();

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


