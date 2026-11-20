using System.Text.RegularExpressions;
using CALCULADORA;
using static System.Console;

var calculadora = new Calculadora();

int numeroElegido = 0;
do
{
    WriteLine("CALCULADORA");
    WriteLine("1. Sumar");
    WriteLine("2. Restar");
    WriteLine("3. Multiplicar");
    WriteLine("4. Dividir");
    WriteLine("5. Módulo");
    Write("Número: ");


} while (!int.TryParse(ReadLine(), out numeroElegido) || numeroElegido > 5 || numeroElegido < 1);

string formato= @"^[\d]+-[\d]+$";
bool numerosVálidos = false;
int num1 = 0;
int num2 = 0;
do
{
    WriteLine("Introduce los dos números de la siguiente manera: n1-n2");
    Write(": ");
    string? input = ReadLine()?.Trim() ?? "0";
    numerosVálidos = Regex.IsMatch(input, formato);
    string[] numeros = input.Split("-");
    int.TryParse(numeros[0], out num1);
    int.TryParse(numeros[1], out num2);
} while (!numerosVálidos);
switch (numeroElegido)
{
    case 1:
        var res1 = calculadora.Sumar(num1, num2); //Aquí haríamos un programilla para pedir números
        WriteLine($"La suma es: {res1}");
        break;
    case 2: 
        var res2 = calculadora.Restar(num1, num2);
        WriteLine($"La resta es: {res2}");
        break;
    case 3:
        var res3 = calculadora.Multiplicar(num1, num2);
        WriteLine($"La multiplicación es: {res3}");
        break;
    case 4:
        var res4 = calculadora.Dividir(num1, num2);
        if (res4 == -1)
        {
            WriteLine("NO SE PUEDE DIVIDIR ENTRE 0");
        }
        else
        {
            WriteLine($"La división es: {res4}");
        }
        break;
    case 5:
        var res5 = calculadora.Módulo(num1, num2);
        if (res5 == -1)
        {
            WriteLine("NO SE PUEDE DIVIDIR ENTRE 0");
        }
        else
        {
            WriteLine($"El módulo es: {res5}");
        }
        break;
}


