﻿// screen sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

//List<string> listaDeBandas = new List<string>{"U2", "The Beatles", "Calipso"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 7 });
bandasRegistradas.Add("Calypso", new List<int>{10, 0, 7});

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine("***************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("***************************");
}

void ExibirOpcoesDoMenu()
{
   while (true)
    {
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar todas as bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para exibir a média de uma banda");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;

        if (!int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerico))
        {
            Console.WriteLine("\nEntrada inválida! Por favor, digite um número.");
            Thread.Sleep(2000);
            continue;
        }

        switch (opcaoEscolhidaNumerico)
        {
            case 1:
                Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
                RegistrarBanda();
                break;

            case 2:
                Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
                MostrarBandasRegistradas();
                break;

            case 3:
                Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
                AvaliarUmaBanda();
                break;

            case 4:
                Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
                ExibirMedia();
                break;

            case -1:
                Console.WriteLine("\nVocê saiu");
                return; // Encerra o loop e a função

            default:
                Console.WriteLine("\nNúmero inválido");
                Thread.Sleep(2000);
                break;
        }
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    //listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.WriteLine("\nDigite qualquer tecla pra voltar");
    Console.ReadKey();
    
}

void MostrarBandasRegistradas()
{
    Console.Clear();

    ExibirTituloDaOpcao("|Exibindo todas as bandas registradas|");
  
    //    for (int i = 0; i < listaDeBandas.Count; i++)
    //    {
    //        Console.WriteLine($"Banda: {listaDeBandas[i]}");
    //    }

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla pra voltar");
    Console.ReadKey();

}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}

void AvaliarUmaBanda()
{
     Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual a nota para a banda {nomeDaBanda}?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(4000);
        Console.WriteLine("\nDigite qualquer tecla pra voltar");
        Console.ReadKey();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("\nDigite qualquer tecla pra voltar");
        Console.ReadKey();
    }
}

void ExibirMedia()
{
   Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda {nomeDaBanda} é {notasDaBanda.Average()}");
        Console.WriteLine("\nDigite qualquer tecla pra voltar");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("\nDigite qualquer tecla pra voltar");
        Console.ReadKey();
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();

