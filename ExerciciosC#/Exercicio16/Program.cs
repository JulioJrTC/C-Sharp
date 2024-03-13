/* Desafio 16: Crie um programa que leia um numero Real qualquer pelo teclado e mostre na tela a sua porção inteira.
Exemplo: Digite um numero: 6.127.
O numero 6.127 tem a parte inteira 6. */

//Greetings!
Console.WriteLine("Bem vindo ao analizador de numeros da Prof(a) Alexa!");

//Tratatamento de erros
while (true)
{
    try
    {
        //Solicitando um valor numerico ao usuario
        Console.Write("\nDigite um numero real (Exemplo 6,127): ");
        string numeroString = Console.ReadLine();

        //Caso o usuario tenha inserido um ponto como ponto separador, iremos substituir esse ponto por uma virgula
        if (numeroString.Contains("."))
        {
            numeroString = numeroString.Replace(".", ",");
        }

        //Convertendo o valor inserido acima em uma variavel double
        double numeroReal = double.Parse(numeroString);

        //Convertendo a variavel acima para Integer e imprimindo a porção inteira armazenada na mesma
        int numeroInt = Convert.ToInt32(Math.Floor(numeroReal));
        Console.WriteLine($"\nO numero {numeroString} tem a parte inteira {numeroInt}.");
        break;
    
    }catch(Exception ex)
    {
        Console.WriteLine("\nErro! Digite somente valores numericos! (Exemplo 6,127)");
    }
}