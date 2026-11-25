//ScreenSound


//List<string> Bandas = new List<string> { "$uicideboy$","Pouya","RAMIREZ"};
using System.Data;

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>()
{
   ["$uicideboy$"] = new  List<int> {10, 8, 9, 7},
   ["Pouya"] = new  List<int> {10, 8, 9, 7},
   ["Linkin Park"] = new  List<int> {10, 8, 9, 7}
};
void Logo()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█ █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█ ▄█ █▄█ █▄█ █░▀█ █▄▀");
}

void OpcoesMenu()
{
    Logo();
    Console.WriteLine("\n1) Registrar Bandas");
    Console.WriteLine("2) Exibir todas as Bandas");
    Console.WriteLine("3) Avaliar uma banda");
    Console.WriteLine("4) Exibir a media de uma banda");
    Console.WriteLine("5) Sair");

    Console.Write("\nDigite a opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            ListaBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MediaBanda();
            break;
        case 5:
            Console.WriteLine($"Vlw mano flw");
            break;
        default:
            Console.WriteLine($"Opção invalida!");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Registrar Bandas");
    Console.Write("Digite o nome da banda que deseja adicionar: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    OpcoesMenu();

}
void ListaBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Bandas Registradas");

    foreach (var banda in bandasRegistradas)
    {
        Console.WriteLine($"Banda: {banda.Key}");
    }


    Console.WriteLine("Precione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    Console.Clear();
    OpcoesMenu();

    // (Metodo For usado anteriormente, mudei para foreach por ser mais limpo)
    //for (int i = 0; i < Bandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {Bandas[i]}");
    //}

    //(Mudei a banda de 'string' para 'var', assim consigo mais controle
    // em exibir somente as bandas e melhorei o codigo, confira como estava antes:
    // foreach (string banda in bandasRegistradas)
    //{
    //    Console.WriteLine($"Banda: {bandasRegistradas.Keyy}");
    //}
}

void ExibirTituloOpcao(string titulo)
{
    int qtdLetras = titulo.Length;
    string equals = string.Empty.PadLeft(qtdLetras, '=');
    Console.WriteLine(equals);
    Console.WriteLine(titulo);
    Console.WriteLine(equals + "\n");
}

void AvaliarBanda()
{
    //digitar banda que desja avaliar
    Console.Clear();
    ExibirTituloOpcao("Avaliar Banda");
    Console.Write("Digite qual banda deseja avaliar: ");
    string avaBanda = Console.ReadLine()!;
    if (bandasRegistradas.Keys.Contains(avaBanda))
    {
        Console.WriteLine($"Qual nota deseja atribuir para {avaBanda}?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[avaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada para {avaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        OpcoesMenu();
    }
    else
    {
        Console.WriteLine($"Nenhuma banda corresponde a {avaBanda}, voltando ao menu principal!");
        Console.Clear();
        OpcoesMenu();
    }
    //saber se a banda existe no dicionario >> atribuir uma nota
    //se não existir, volta ao menu principal
}
void MediaBanda()
{
    // lista às bandas para o usuário e pergunta qual ele quer ver a média
    Console.Clear();
    foreach (var banda in bandasRegistradas)
    {
        Console.WriteLine($"Banda: {banda.Key}");
    }
    Console.Write("Qual banda deseja visualizar a média de notas?: ");
    string mediaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(mediaBanda))
    {
        double media = bandasRegistradas[mediaBanda].Average();
        Console.WriteLine($"\nA média da banda {mediaBanda} é de {media}.");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear() ;
        OpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nNenhuma banda corresponde a {mediaBanda}");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        OpcoesMenu();
    }
    
    // limpa o console e volta para a tela de opções
}
OpcoesMenu();




