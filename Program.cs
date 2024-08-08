Dictionary <string, List<int>> dBandasRegistradas = new Dictionary<string, List<int>>();

dBandasRegistradas.Add("U2", new List<int> { 10, 8, 6});
dBandasRegistradas.Add("Marron Five", new List<int>());

string mensagemBoasVindas = "Saudações ao Screen Sound";

void MensagemBoasVindas()
{
    Console.Clear();
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
}

void PainelPrincipal()
{
    Console.WriteLine($"{mensagemBoasVindas}\n");
    Console.WriteLine("Digite 1 para REGISTRAR UMA BANDA");
    Console.WriteLine("Digite 2 para MOSTRAR TODAS AS BANDAS");
    Console.WriteLine("Digite 3 para AVALIAR UMA BANDA");
    Console.WriteLine("Digite 4 para EXIBIR A MÉDIA DE UMA BANDA");
    Console.WriteLine("\nDigite 0 para SAIR\n");

    Console.Write("Digite a sua escolha: ");
    string escolhaUsuario = Console.ReadLine()!;
    int escolhaUsuarioInt = int.Parse(escolhaUsuario);

    switch (escolhaUsuarioInt)
    {
        case 0:
            Console.WriteLine("Byee (;");
            break;
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarBandas();
            break;
        case 4: 
            ExibirMediaBanda();
            break;
        default: 
            Console.WriteLine("Nao existe essa opção!");
            break;
    }
}

void RegistrarBanda()
{
    MensagemBoasVindas();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBandaRegistro = Console.ReadLine()!;
    dBandasRegistradas.Add(nomeBandaRegistro, new List<int>());
    Console.WriteLine($"A Banda {nomeBandaRegistro} Foi Registrada com Sucesso!");
    Thread.Sleep(2000);
    FuncaoPrincipal();
}

void MostrarBandasRegistradas()
{
    MensagemBoasVindas();
    ExibirTituloDaOpcao("Mostrar Todas Bandas Registradas");

    foreach (string banda in dBandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.Write("\nDigite uma tecla para voltar ao menu principal ");
    Console.ReadKey();
    FuncaoPrincipal();
}

void AvaliarBandas()
{
    MensagemBoasVindas();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (dBandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Digite a nota que {nomeDaBanda} merece: ");
        int notaBanda = int.Parse(Console.ReadLine()!);
        dBandasRegistradas[nomeDaBanda].Add(notaBanda);
        Console.WriteLine($"\nA Nota {notaBanda} foi registrada à {nomeDaBanda} com sucesso!");
        Thread.Sleep(3000);
        FuncaoPrincipal();
    } else
    {
        Console.WriteLine($"\nA Banda {nomeDaBanda} não foi encontrada!");
        Console.Write("\nDigite uma tecla para voltar ao menu ");
        Console.ReadKey();
        FuncaoPrincipal();
    }
}

void ExibirMediaBanda()
{
    MensagemBoasVindas();
    ExibirTituloDaOpcao("Mostrar Avaliação de Banda");
    Console.Write("Qual banda você deseja ver a média: ");
    string nomeBandaMedia = Console.ReadLine()!;
    if (dBandasRegistradas.ContainsKey(nomeBandaMedia))
    {
        List<int> notasDaBanda = dBandasRegistradas[nomeBandaMedia];
        Console.WriteLine($"\nA média da Banda {nomeBandaMedia} é {notasDaBanda.Average()}");
        Console.Write("\nDigite uma tecla para voltar ao menu ");
        Console.ReadKey();
        FuncaoPrincipal();
    } else
    {
        Console.WriteLine($"\nA Banda {nomeBandaMedia} não foi encontrada!");
        Console.Write("\nDigite uma tecla para voltar ao menu ");
        Console.ReadKey();
        FuncaoPrincipal();
    }
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void FuncaoPrincipal()
{
    MensagemBoasVindas();
    PainelPrincipal();
}

FuncaoPrincipal();
