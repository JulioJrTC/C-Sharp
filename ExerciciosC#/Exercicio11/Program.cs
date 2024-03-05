/* Desafio 11: Faça um programa que leia a largura e a altura de uma parede em metros, calcule a sua área
e a quantidade de tinta necessaria para pinta-la, sabendo que cada litro de tinta, pinta uma area de 2m². */

Console.Write("Digite um valor numerico para a largura: ");
double largura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite um valor numerico para a altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

double area = largura * altura;

double quantTinta = area/2;

Console.WriteLine($"Será necessario {quantTinta:N2}l de tinta para pintar uma area de {area:N2}m².");