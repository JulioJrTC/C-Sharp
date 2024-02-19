//Desafio 08: Escreva um programa que leia um valor em metros e o exiba convertido em centímetros e milímetros.

double numM,numCM,numMM;

//Solicitando um valor numerico (double) em Metros.
Console.Write("Digite um valor numerico em Metros: (m)");
numM = Convert.ToDouble(Console.ReadLine());

//Convertendo o valor em Metros digitado acima para Centimetros.
numCM = numM * 100;

//Convertendo o valor em Metros digitado acima para Milimetros.
numMM = numM * 1000;

//Imprimindo o resultado.
Console.WriteLine($"{numM}(m) equivale a {numCM}(cm) e {numMM}(mm).");