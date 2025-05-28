// Screen Sound

string mensagemBoasVindas = "Bem-vindo ao Screen Sound!";

void ExibirMensagemBoasVindas()
{ 
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemBoasVindas);
}


void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 para registrar uma música");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("Digite a opção: ");
    string opcaoEscolhida = Console.ReadLine();

    if (opcaoEscolhida == "1")
    {
        Console.WriteLine("Você digitou a opção: " + opcaoEscolhida);
        // Lógica para registrar uma música
    }
    else if (opcaoEscolhida == "2")
    {
        Console.WriteLine("Você digitou a opção: " + opcaoEscolhida);
        // Lógica para mostrar todas as bandas
    }
    else if (opcaoEscolhida == "3")
    {
        Console.WriteLine("Você digitou a opção: " + opcaoEscolhida);

        // Lógica para avaliar uma banda
    }
    else if (opcaoEscolhida == "4")
    {
        Console.WriteLine("Você digitou a opção: " + opcaoEscolhida);
        // Lógica para exibir a média de uma banda
    }
    else if (opcaoEscolhida == "-1")
    {
        Console.WriteLine("Você digitou a opção: " + opcaoEscolhida);

        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
        ExibirOpcoesDoMenu();
    }
}


ExibirMensagemBoasVindas();

ExibirOpcoesDoMenu();