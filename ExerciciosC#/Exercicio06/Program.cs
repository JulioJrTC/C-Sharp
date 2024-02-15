//Desafio 06: Crie um algoritmo que leia um numero e mostre o seu dobro, triplo e raiz quadrada.

Console.Write("Digite um valor numerico: ");
int num = Convert.ToInt32(Console.ReadLine());

int numDobro = num * 2;
int numTriplo = num * 3;
double numRaizQuadrada = Math.Sqrt(num);

Console.WriteLine($"O numero {num} tem como dobro o numero {numDobro}, triplo {numTriplo} e Raiz Quadrada ~{numRaizQuadrada}.");


