/* Desafio 17: Faça um programa que leia o comprimento do cateto oposto e do cateto adjacente de um triangulo retângulo, calcule e mostre o comprimento da hipotenusa. */

//Greetings!
Console.WriteLine("Bem Vindo ao Calculador de Cateto Oposto, Adjacente e Hipotenusa da Prof(a) Alexa!");

//Declarando uma variavel para o Cateto Adjacente
int ca;

//Tratamento de erro
while (true)
{
    try
    {
        //Solicitando um valor para o Cateto Adjacente
        Console.Write("\nDigite um valor para o cateto adjacente: ");
        ca = Convert.ToInt32(Console.ReadLine());
        break;
    }catch (FormatException ex)
    {
        Console.WriteLine("Erro! Por favor não digite valores alem de numeros!");
    }
}

//Declarando uma variavel para o Cateto Oposto
int co;

while (true)
{
    try
    {
        //Solicitando um valor para o Cateto Oposto
        Console.Write("\nDigite um valor para o cateto oposto: ");
        co = Convert.ToInt32(Console.ReadLine());
        break;
    }catch(FormatException ex)
    {
        Console.WriteLine("Erro! Por favor não digite valores alem de numeros!");
    }
}

//O valor de ca será elevado a 2º potencia (quadrado)
int ca_quadrado = (int) Math.Pow(ca,2);

//O valor de co será elevado a 2º potencia (quadrado)
int co_quadrado = (int) Math.Pow(co, 2);

//Somando os valores acima
int soma_CaCo = (ca_quadrado + co_quadrado);

//Usando raiz quadrada para calcularmos a hipotenusa usando o resultado do calculo acima
int hipo = (int) Math.Sqrt(soma_CaCo);

//Imprimindo os resultados matematicos e o comprimento da hipotenusa
Console.WriteLine($"\nElevamos os valores de Ca({ca}) e Co({co}) a 2º potencia, e os resultados foram: \nCa²: {ca_quadrado}\nCo²: {co_quadrado} " +
    $"\nSomamos ambos os valores e o resultado foi {soma_CaCo} \nUsando raiz quadrada no resultado da soma, o valor final da hipotenusa é {hipo}.");