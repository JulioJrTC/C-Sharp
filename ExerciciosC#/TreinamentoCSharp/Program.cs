//Treinamento C#

//Solicitando um valor String ao usuario
using System.Text.RegularExpressions;

Console.Write("Digite um valor (String): ");
String valorDigitado = Console.ReadLine();


if (!Regex.IsMatch(valorDigitado, "^[A-Za-z]+$"))
{
    Console.WriteLine("Erro! Vc digitou algum valor alem de Strings!");    
}