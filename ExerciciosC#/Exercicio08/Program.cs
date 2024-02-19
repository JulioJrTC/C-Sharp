//Desafio 08: Escreva um programa que leia um valor em metros e o exiba convertido em centímetros e milímetros.

//Declarando variaveis Double que irão receber valores numericos em Metros, Centimetros e Milimetros.
double numM,numCM,numMM;

//Tratamento de erro.
while (true)
{
    try
    {
        //Solicitando um valor numerico (double) em Metros.
        Console.Write("Digite um valor numerico em Metros: (m)");
        numM = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch(FormatException ex)
    {
        Console.WriteLine("Erro! Digite somente valores numericos (Exemplo 6.9");
    }
}

//Convertendo o valor em Metros digitado acima para Centimetros.
numCM = numM * 100;

//Convertendo o valor em Metros digitado acima para Milimetros.
numMM = numM * 1000;

//Imprimindo o resultado.
Console.WriteLine($"{numM}(m) equivale a {numCM}(cm) e {numMM}(mm).");