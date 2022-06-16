
using ProjetoFinalPOOI;

var pessoa = Pessoa.Ler();
var carro = Carro.Ler();

int opcao;




//uns objetos aqui

//do pra prender o meliante aqui
Console.Write("Digite uma opção\n" +
              "(1) Cadastrar pessoa\n" +
              "(2) Cadastrar Carro\n" +
              "(3) Alugar ou devolver carro\n" +
              "(4) Sair\n" +
              "Opção: ");
int.TryParse(Console.ReadLine(), out opcao);

switch (opcao)
{
    case 1:
        //tentar retornar ao anterior
        //usar o mesmo int opção
        int opcao2;
        Console.Write("Digite uma opção\n" +
                      "(1) Cadastrar Funcionário\n" +
                      "(2) Cadastrar Cliente\n" +
                      "Opção: ");
        int.TryParse(Console.ReadLine(), out opcao2);
        //chamar a classe pessoa - incializar essa "vazia"
        //baseado na opção do usuario vai instanciar em funcionario ou cliente
        break;
    case 2:
        //pedir os dados metodo Dados()
        break;
    case 3:
        int opcao3;
        Console.Write("Digite uma opção\n" +
              "(1) Alugar\n" +
              "(2) Devolver\n" +
              "Opção: ");
        int.TryParse(Console.ReadLine(), out opcao3);

        // if (1)
        //diponiveis()
        //alugar()

        //else 
        //metodos devolução

        break;
    case 4:
        return;
        break;

    default:
        break;
}


