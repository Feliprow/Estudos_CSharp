namespace Estudos_CSharp;

public class Strings
{
    public static void Main(string[] args)
    {
        // INTRODUÇÃO Á STRINGS

// declaração igual as outras linguagens
        String apresentacao = "Olá mundo!";

// Console.WriteLine -> println (quebra linha)
        Console.WriteLine(apresentacao);

// Declaração padrão das linguagens
        String meuNome = "Felipe";

// Concatenação em C#
        Console.WriteLine("Meu nome é: " + meuNome);

        String nomeNamorada = "Andreza";

// Interpolação moderna em C#
        Console.WriteLine($"Olá meu nome é {meuNome} e eu namoro a {nomeNamorada}");

// Declarando String com espaços
        String saudacaoComEspaco = "     Olá, Saudações!       ";

        Console.WriteLine($"[{saudacaoComEspaco}]");

// FUNÇÃO .Trim() tira os espaços antes e depois da String
        String saudacaoSemEspaco = saudacaoComEspaco.Trim();
        Console.WriteLine($"[{saudacaoSemEspaco}]");
        Console.WriteLine($"{saudacaoComEspaco.TrimEnd()}");

// FUNÇÃO .Replace() substitui uma parte da String por outra String 
// .Replace("<string antiga>" , "<string nova")
        String fabula = "Era uma vez um lindo ponei";
        Console.WriteLine(fabula.Replace("ponei", "corvete"));
        Console.WriteLine(fabula.ToUpper().Replace("PONEI", "pombo"));


// FUNÇÃO .Contains(): Procura o primeiro índice da ocorrência.
// Replace("<ocorrência>") -> retorna boolean 
        String musica = "Buscando um novo rumo que faça sentido nesse mundo louco, com o coração partido";
        Console.WriteLine(musica.Contains("louco"));

// Funcionamento similar a .Contains()
        Console.WriteLine(musica.StartsWith("louco"));
        Console.WriteLine(musica.EndsWith("partido"));
    }
}