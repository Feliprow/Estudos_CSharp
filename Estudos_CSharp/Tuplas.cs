namespace Estudos_CSharp;

public class Tuplas
{
    public static void Main(string[] args)
    {
        // ============================================================
// TUPLAS
// ============================================================
// As tuplas são como as structs em C mas de um jeito mais compacto

        var meusDados = (nome: "felipe", idade: 26);

        Console.WriteLine(meusDados.nome + " Idade: " + meusDados.idade);

        meusDados.idade++;

        Console.WriteLine(meusDados.idade);

// fazendo copia da tupla sem modificar a original

        var tuplaCopia = meusDados with { nome = "Andreza", idade = 26 };
// Util para alterar algum componente específico

        Console.WriteLine(tuplaCopia);

// DICA!!!! não precisa usar variável auxiliar (mão na roda hein!)
        int x = 1, y = 2;
        (x, y) = (y, x); // swap idiomático em C#
// Funciona com multiplos valores

// ============================================================

// podemos usar as tuplas como tipos de retorno em funções

// o tipo de retorno é uma tupla (int, int)
        (int quociente, int resto) Dividir(int a, int b)
        {
            return (a / b, a % b);
        }

        var resultado = Dividir(10, 3); // a tupla foi criada no ()
        Console.WriteLine(resultado.quociente); // 3
        Console.WriteLine(resultado.resto); // 1

// ============================================================
//              RECORDS
// ============================================================
/* Records basicamente são objetos que devem guardar apenas os dados
 * não devem ter métodos en sí
 *
 */

//Point pt3 = new Point(1, 1);
//var pt4 = pt3 with { Y = 10 };
//Console.WriteLine($"The two points are {pt3} and {pt4}");


//Dados Feliprow = new Dados("Feliprow", 26);
//Console.WriteLine(Feliprow.nome + " Idade: " + Feliprow.idade);


// Records devem ficar no final do código
//public record Dados(String nome, int idade);
//public record Point(int X, int Y);


// tipo class é um tipo referência
    }
}