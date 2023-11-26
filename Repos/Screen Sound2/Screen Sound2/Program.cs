//Screen Sound
//string que representa um texto
string mensagem =("Bem vindo ao Screen Sound");
//método exibir mensagem
void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("\n"+mensagem+"\n");
}

//método exibir menu
void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    //recebe e converte escolha
    int numEscolha = int.Parse(Console.ReadLine()!);

    //switch opçao escolhida
    switch (numEscolha)
    {
        case 1:
            Console.WriteLine("Você escolheu a opção " + numEscolha);
            break;
        case 2:
            Console.WriteLine("Você escolheu a opção " + numEscolha);
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + numEscolha);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + numEscolha);
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção " + numEscolha);
            break;

    } 
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();


