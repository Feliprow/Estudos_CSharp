namespace Estudos_CSharp;

public class Numeros
{
    public static void Main()
    { 
// ============================================================
// ARITMÉTICA COM INT
// ============================================================
    
        int intA = 10;
        int intB = 6;
        int intC = intA + intB;
        Console.WriteLine(intC);

        Console.WriteLine($"Adição:        {intA} + {intB} = {intA + intB}");
        Console.WriteLine($"Subtração:     {intA} - {intB} = {intA - intB}");
        Console.WriteLine($"Multiplicação: {intA} * {intB} = {intA * intB}");
        Console.WriteLine($"Divisão:       {intA} / {intB} = {intA / intB}");
        Console.WriteLine($"Módulo:        {intA} % {intB} = {intA % intB}");

// ============================================================
// ORDEM DE PRECEDÊNCIA
// ============================================================

// *, / e % têm prioridade sobre + e -
        intC = 10 + 10 * 5 / 2 % 2;
        Console.WriteLine($"10 + 10 * 5 / 2 % 2   = {intC}");

// Parênteses forçam a ordem desejada
        intC = (10 + 10) * 5 / 2 % 2;
        Console.WriteLine($"(10 + 10) * 5 / 2 % 2 = {intC}");

// ============================================================
// TRUNCAMENTO E OVERFLOW
// ============================================================

        int e = 7;
        int f = 4;
        int g = 3;
        int h = (e + f) / g;

// int descarta a parte decimal sem arredondar (truncate)
        Console.WriteLine($"({e} + {f}) / {g} = {h}  (truncado)");
        Console.WriteLine($"({e} + {f}) % {g} = {(e + f) % g}  (resto)");

// Overflow: ultrapassar os limites faz o valor ciclar
//Console.WriteLine($"int.MaxValue + 1: {int.MaxValue + 1}  (estoura → vai para MinValue)");
//Console.WriteLine($"int.MinValue - 1: {int.MinValue - 1}  (estoura → vai para MaxValue)");

// ============================================================
// DOUBLE
// ============================================================

// double tem imprecisão de arredondamento — evitar para valores monetários
        double doubleA = 5;
        double doubleB = 4;
        double doubleC = 2;
        double doubleD = (doubleA + doubleB) / doubleC;
        Console.WriteLine(doubleD);

        Console.WriteLine($"Range: {double.MinValue} até {double.MaxValue}");
        Console.WriteLine($"1.0 / 3.0 (double) = {1.0 / 3.0}");

// Desafio: média de notas — cast necessário para não truncar
        int nota1 = 10;
        int nota2 = 8;
        int nota3 = 7;
        double media = (nota1 + nota2 + nota3) / 3.0; // 3.0 força divisão em ponto flutuante
        Console.WriteLine($"Média: {media}");

// ============================================================
// DECIMAL
// ============================================================

// decimal: menor range que double, porém maior precisão
// usar para valores monetários ou que exigem alta precisão
        Console.WriteLine($"Range: {decimal.MinValue} até {decimal.MaxValue}");

        Console.WriteLine($"1.0 / 3.0 (double)  = {1.0 / 3.0}");
        Console.WriteLine($"1.0 / 3.0 (decimal) = {1.0M / 3.0M}"); // sufixo M obrigatório em literais decimal
    }
}