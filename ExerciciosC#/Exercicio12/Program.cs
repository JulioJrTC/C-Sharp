// Desafio 12: Faça um algoritmo que leia o preço de um produto e mostre seu novo preço, com 5% de desconto.

//Biblioteca referente ao "Regex" (tratamento de erro)
using System.Text.RegularExpressions;

//Greetings!
Console.WriteLine("Bem vindo ao descontador de preço da Alexa!");

//Declarando uma variavel String que iremos usar para tratarmos de possiveis erros
string preco;

//Tratamento de erro
while (true)
{
    //Solicitando um valor monetario ao usuario
    Console.Write("Insira um valor monetario (Exemplo: 9,99): ");
    preco = Console.ReadLine();

    //Se o usuario digitar qualquer valor alem de valores numericos, iremos exibir um erro
    if(Regex.IsMatch(preco, "^[A-Za-z]+$"))
    {
        Console.WriteLine("Erro! Digite somente valores numericos!");
    }
    else {break;}
}

//Se o usuario digitar um ponto em vez de virgula com ponto separador, iremos substituir esse ponto por uma virgula
if (preco.Contains("."))
{
    preco = preco.Replace(".", ",");
}

//Declarando uma nova variavel que irá receber o valor digitado e tratato acima convertido para double
double precoOriginal = Convert.ToDouble(preco);

//Desconto
int desconto = 5;

//Formula matematica para o calculo do novo preço
double novoPreco = precoOriginal - (precoOriginal * desconto / 100);

//Imprimindo resultado final
Console.WriteLine($"O produto que antes custava R${precoOriginal:N2}, com {desconto}% de desconto irá custar R${novoPreco:N2}");