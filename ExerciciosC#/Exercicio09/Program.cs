//Desafio 09: Faça um programa que leia um número inteiro qualquer e mostre na tela a sua tabuada.

//Variavel declarada que irá receber um valor numerico.
int num;

//Tratamento de erro.
while (true)
{
    try
    {
        //Solicitando um valor numerico para a tabuada.
        Console.Write("Digite um valor numerico para a tabuada: ");
        num = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch(FormatException ex)
    {
        Console.WriteLine("\nErro! Digite somente valores numericos! (Exemplo 69)\n");        
    }    
}

//Imprimindo a tabuada.
Console.WriteLine($"\nTabuada do {num}:");
for(int n = 1; n < 11; n++) {Console.WriteLine($"{num}x{n} = {num * n}");}