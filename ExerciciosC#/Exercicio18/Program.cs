/* Desafio 18: Faça um programa que leia um angulo qualquer e mostre na tela o valor do seno, cosseno e tangente desse angulo. */

Console.WriteLine("Bem vindo ao analizador de angulos, seno, cosseno e tangente da prof(a) Alexa!");

Console.Write("Digite um valor para o angulo: ");
double angulo = Convert.ToDouble(Console.ReadLine());

double seno = Math.Sin(angulo);
double cosseno = Math.Cos(angulo);
double tangente = Math.Tan(angulo);

Console.WriteLine($"Seno: {seno}\nCosseno: {cosseno}\nTangente: {tangente}");