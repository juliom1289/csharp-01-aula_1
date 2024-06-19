//Screen Sound
//string mensagemBoasVindas = "Boas vindas ao Screen Sound";


/*void ExibirMensagemDeBoasVindas() {
    Console.WriteLine("***************************");
    Console.WriteLine(mensagemBoasVindas);
    Console.WriteLine("***************************");

}*/

//VERBATIN LITERAL
//site: fsymsols.com
void ExibirMensagemDeBoasVindas2() {
    Console.WriteLine(@"
╔═══╗──────────────╔═══╗──────────╔╗
║╔═╗║──────────────║╔═╗║──────────║║
║╚══╦══╦═╦══╦══╦═╗─║╚══╦══╦╗╔╦═╗╔═╝║
╚══╗║╔═╣╔╣║═╣║═╣╔╗╗╚══╗║╔╗║║║║╔╗╣╔╗║
║╚═╝║╚═╣║║║═╣║═╣║║║║╚═╝║╚╝║╚╝║║║║╚╝║
╚═══╩══╩╝╚══╩══╩╝╚╝╚═══╩══╩══╩╝╚╩══╝");
}

void ExibirOpcoesDeMenu() {
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de avaliações de uma banda");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nDigite a sua opção: ");
    int opcaoEscolhida = LeituraDeOpcoes();

    while (opcaoEscolhida > 5 || opcaoEscolhida < 1) {
        Console.WriteLine("Você escolheu uma opção inválida. Tente novamente");
        opcaoEscolhida = LeituraDeOpcoes();
    }

    DeclaraOpcaoEscolhida(opcaoEscolhida);


    static int LeituraDeOpcoes() {
        string opcaoEscolhida = Console.ReadLine()!;
        return int.Parse(opcaoEscolhida);
    }

    static void DeclaraOpcaoEscolhida(int opcao) {
        Console.WriteLine("Você escolheu a opção " + opcao);
    }


} 

ExibirMensagemDeBoasVindas2();
ExibirOpcoesDeMenu();
