// Desafio 13: Faça um algoritmo que leia o salário de um funcionário e mostre seu novo salário, com 15% de aumento.

//Usando da biblioteca abaixo para tratarmos erros
using System.Text.RegularExpressions;

//Greetings!
Console.WriteLine("Bem vindo ao calculador de salario da Thorn's Club, lider: Alexa");

//Declarando uma variavel string para o nome do funcionario
string nomeFuncionario;

//Tratamento de erro
while (true)
{
    //Solicitando o nome do funcionario
    Console.Write("\nDigite o nome do funcionario: ");
    nomeFuncionario = Console.ReadLine();    

    //Se for inserido qualquer valor alem de palavras, iremos exibir um erro
    if (!Regex.IsMatch(nomeFuncionario, "[A-Za-z]")){
        Console.WriteLine("\nErro! Não digite caracteres alem de palavras!");
    }
    else
    {
        break;
    }
}

//Declarando uma variavel que inicialmente irá conter o salario atual em string
string salario;

//Irems tratar do valor referente a variavel acima e armazenar o valor tratado em uma nova variavel double
double salarioAtual;

//Tratamento de erro
while (true)
{
    try
    {
        //Solicitando o salario atual do funcionario
        Console.Write("\nDigite seu salario atual: R$");
        salario = Console.ReadLine();

        //Se o usuario inserir um ponto com ponto separador, iremos substituir esse ponto por uma virgula
        if (salario.Contains("."))
        {
            salario = salario.Replace(".", ",");
        }

        //Variavel double que irá receber o valor tratado e convertido acima 
        salarioAtual = Convert.ToDouble(salario);  
        break;

    }catch (FormatException ex)
    {
        Console.WriteLine("\nErro! Digite somente valores numericos (Exemplo 1500,50)");
    }
}

//Declarando uma variavel integer para o percentual de aumento do salario
int aumento;

//Tratamento de erro
while (true)
{
    try
    {
        //Solicitando em quantos % será o aumento
        Console.Write("\nQuanto será o aumento: (Exemplo '5' para 5% de aumento): ");
        aumento = Convert.ToInt32(Console.ReadLine());
        break;
    }catch(FormatException ex)
    {
        Console.WriteLine("\nErro! Digite somente valores numericos (Exemplo 10 para 10% de aumento)");
    }
}

//Calculando novo salario
double novoSalario = salarioAtual+(salarioAtual * aumento / 100);

//Imprimindo novo salario
Console.WriteLine($"\nParabens {nomeFuncionario}! Seu salario que antes era R${salarioAtual:N2}, com {aumento}% de aumento seu novo salario será R${novoSalario:N2}!");