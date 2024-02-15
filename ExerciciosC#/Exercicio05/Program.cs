//Desafio 05: Faça um programa que leia um número inteiro e mostre na tela o seu sucessor e seu antecessor.

//Greetings!
Console.WriteLine("Bem vindo ao numerador da Prof(a) Alexa!");

//Programa principal
while (true)
{
    //Solicitando um numero (e convertendo o valor inserido para Integer)
    int num;
    while (true)
    {
        try
        {
            Console.Write("\nDigite um numero (ou digite 000 para sair): ");
            num = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (FormatException e)
        {
            Console.WriteLine("Erro! Digite somente valores numericos!");
        }
    }

    if (num != 000)
    {
        //Variavel que irá conter um valor numerico antecessor ao numero inserido pelo usuario
        int numAnt = num - 1;

        //Variavel que irá conter um valor numerico sucessor ao numero inserido pelo usuario
        int numSuc = num + 1;
        
        //Imprimindo o resultado
        Console.WriteLine($"O numero {num} tem seu antecessor {numAnt} e sucessor {numSuc}.");

        //Efeito de pausa/loading
        Thread.Sleep(2000);

    }
    else
    {
        Console.WriteLine("Obrigado, e volte sempre!");
        break;
    }

}