//Desafio 06: Crie um algoritmo que leia um numero e mostre o seu dobro, triplo e raiz quadrada.

//Declarando variaveis int e double
int num, numDobro, numTriplo;
double numRaizQuadrada;

//Greetings!
Console.WriteLine("Bem vindo ao calcular de numeros da Prof(a) Alexa!");

//Tratamento de erro
while (true)
{
    try
    {
        //Solicitando um valor numerico (e convertendo a variavel para Int)
        Console.Write("Digite um valor numerico: ");
        num = Convert.ToInt32(Console.ReadLine());
        break;
    }catch(FormatException ex) {Console.WriteLine("Erro! Digite somente valores numericos!");}
}

//Variaveis matematicas para o calculo do dobro, triplo e raiz quadrada
numDobro = num * 2;
numTriplo = num * 3;
numRaizQuadrada = Math.Sqrt(num);

//Imprimindo o resultado
Console.WriteLine($"O numero {num} tem como dobro o numero {numDobro}, triplo {numTriplo} e Raiz Quadrada {numRaizQuadrada}.");