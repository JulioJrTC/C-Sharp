using System.Text.RegularExpressions;
//Desafio 02: Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boas-vidas.

while (true)
{
    //Solicitando o nome de uma pessoa e o armazenando em uma variavel String
    Console.Write("Digite seu nome: ");
    String nomePessoa = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nomePessoa) || !Regex.IsMatch(nomePessoa, "^[A-Za-z]+$"))
    {
        Console.WriteLine("Erro!");
    }
    else
    {
        //Imprimindo o resultado
        Console.WriteLine($"Olá {nomePessoa}, bem vindo ao C#!");
        break;
    }
}