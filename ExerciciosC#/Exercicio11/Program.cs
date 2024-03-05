/* Desafio 11: Faça um programa que leia a largura e a altura de uma parede em metros, calcule a sua área
e a quantidade de tinta necessaria para pinta-la, sabendo que cada litro de tinta, pinta uma area de 2m². */

using System.Text.RegularExpressions;

//Declarando variaveis para altura e largura que inicialmente serão variaveis String
string l, a;

while (true)
{
    //Solicitando ao usuariuo um valor numerico para a largura
    Console.Write("Digite um valor numerico para a largura: ");
    l = Console.ReadLine();

    if (Regex.IsMatch(l, "[A-Za-z]"))
    {
        Console.WriteLine("Erro! Digite somente valores numericos!");
    }
    else{ break;}
}

//Se o usuario inserir um ponto como ponto separador, iremos substituir o mesmo por uma virgula
if (l.Contains("."))
{
    l = l.Replace(".", ",");
}

//Inserindo a largura a uma variavel Double
double largura = Convert.ToDouble(l);

while (true)
{
    //Solicitando ao usuariuo um valor numerico para a altura
    Console.Write("Digite um valor numerico para a altura: ");
    a = Console.ReadLine();

    if (Regex.IsMatch(a, "[A-Za-z]"))
    {
        Console.WriteLine("Erro! Digite somente valores numericos!");
    }
    else { break;}
}

//Se o usuario inserir um ponto como ponto separador, iremos substituir o mesmo por uma virgula
if (a.Contains("."))
{
    a = a.Replace(".", ",");
}

//Inserindo a altura a uma variavel Double
double altura = Convert.ToDouble(a);

//Calculando area
double area = largura * altura;

//Calculando a quantidade de tinta necessaria
double quantTinta = area/2;

//Imprimindo o resultado
Console.WriteLine($"Será necessario {quantTinta:N2}l de tinta para pintar uma area de {area:N2}m².");