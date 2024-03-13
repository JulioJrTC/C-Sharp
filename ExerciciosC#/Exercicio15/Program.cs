﻿/* Desafio 15: Escreva um programa que pergunte a quantidade de Km percorridos por um carro alugado e a quantidade de dias pelos quais ele foi alugado.
Calcule o preço a pagar, sabendo que o carro custa R$60 por dia e R$0,15 por Km rodado. */

//Greetings!
Console.WriteLine("Bem vindo ao radar de carros da Alexa!");

//Perguntando ao usuario quantos KMs o carro percorreu
Console.Write("\nQuantos Kms seu carro percorreu: ");
int kmPercorrido = Convert.ToInt32(Console.ReadLine());

//Perguntando ao usuario quantos dias o carro foi alugado
Console.Write("\nQuantos dias o carro foi alugado: ");
int diasAlugados = Convert.ToInt32(Console.ReadLine());

//Calculando valor a pagar de acordo com a quantidade de dias alugados (R$60 por dia)
double dias_aPagar = diasAlugados * 60;
Console.WriteLine($"\nDias alugados: {diasAlugados}, valor a pagar: R${dias_aPagar:N2}");

//Calculando o valor a pagar de acordo com a quantidade de KMs percorridos (R$0.15 por KM)
double km_aPagar = kmPercorrido * 0.15;
Console.WriteLine($"\nKMs percorridos: {kmPercorrido}, valor a pagar: R${km_aPagar:N2}");

//Calculando e imprimindo o valor TOTAL a pagar
double total_aPagar = (dias_aPagar + km_aPagar);
Console.WriteLine($"\nTotal a pagar: R${total_aPagar:N2}!");







