/* Desafio 18: Faça um programa que leia um angulo qualquer e mostre na tela o valor do seno, cosseno e tangente desse angulo. */

Console.WriteLine("Bem vindo ao analizador de angulos, seno, cosseno e tangente da prof(a) Alexa!");

//Declarando uma variavel para o Cateto Adjacente
double ca;

//Tratamento de erro
while (true)
{
    try
    {
        //Solicitando um valor para o Cateto Adjacente
        Console.Write("\nDigite um valor para o cateto adjacente: ");
        ca = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Erro! Por favor não digite valores alem de numeros!");
    }
}

//Declarando uma variavel para o Cateto Oposto
double co;

while (true)
{
    try
    {
        //Solicitando um valor para o Cateto Oposto
        Console.Write("\nDigite um valor para o cateto oposto: ");
        co = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Erro! Por favor não digite valores alem de numeros!");
    }
}

//O valor de ca será elevado a 2º potencia (quadrado)
double ca_quadrado = Math.Pow(ca, 2);

//O valor de co será elevado a 2º potencia (quadrado)
double co_quadrado = Math.Pow(co, 2);

//Somando os valores acima
double soma_CaCo = (ca_quadrado + co_quadrado);

//Usando raiz quadrada para calcularmos a hipotenusa usando o resultado do calculo acima
double hipo = Math.Sqrt(soma_CaCo);

//Seno
double seno = ca / hipo;

//Cosseno
double cosseno = co / hipo;

//Tangente
double tangente = co / ca;

Console.WriteLine($"\nSeno: {seno}\nCosseno: {cosseno}\nTangente: {tangente}.");