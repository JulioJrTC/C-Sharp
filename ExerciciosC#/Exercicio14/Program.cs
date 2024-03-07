// Desafio 14: Escreva um programa que converta uma temperatura digitada em ºC e converta para ºF.

//Usando da biblioteca abaixo para tratamento de erro
using System.Text.RegularExpressions;

//Declarando variavel para a Temperatura em C
int tempC;

//Greetings!
Console.WriteLine("Bem vindo ao conversor de temperaturas da professora Alexa!");

//Loop
while (true)
{
    //Tratamento de erro
    while (true)
    {
        try
        {
            //Solicitando ao usuario uma temperatura em ºC
            Console.Write("Insira uma temperatura em ºC: (Exemplo 32ºC): ");
            tempC = Convert.ToInt32(Console.ReadLine());
            break;

        }
        catch (FormatException ex) { Console.WriteLine("\nErro! Digite um valor numerico valido! (Exemplo 32)"); }
    }

    //Efetuando a conversão para ºF
    int tempF = tempC * 9 / 5 + 32;

    //Imprimindo resultado da conversão
    Console.WriteLine($"{tempC}ºC é igual a {tempF}ºF.");

    //Declarando variavel String para escolha do usuario
    string c;

    //Tratamento de erro
    while (true)
    {
        Console.WriteLine("\nDeseja continuar? [S/N]");
        c = Console.ReadLine().ToUpper();

        if (!Regex.IsMatch(c, "[SNsn]")){
            Console.WriteLine("\nErro! Digite somente S (para Sim) ou N (para Não)!");
        }
        else{break;}
    }

    if (c.Equals("N"))
    {
        Console.WriteLine("\nObrigado e volte sempre!");
        break;
    }

}