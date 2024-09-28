using Classificador_de_Nivel_de_Heroi.models;

string nivel = "";
string continuar = "";

// Instância da classe herói.
Heroi h = new Heroi();

// Looping para receber do usuário o nome e o XP do herói.
do
{
    Console.Write("Digite o nome do seu herói: ");
    h.Nome = Console.ReadLine();

    Console.Write("Quanto de experiência ele possui? ");
    h.XP = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    h.NivelDoHeroi(nivel);

    Console.WriteLine();

    Console.WriteLine("Deseja repetir?[S/N]");
    continuar = Console.ReadLine();

    Console.Clear();
} while (continuar != "N");

Console.WriteLine("Boa jornada!");