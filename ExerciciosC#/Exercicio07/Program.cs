//Desafio 07: Desenvolva um programa que leia as duas notas de um aluno, calcule e mostre a sua média.

//Declarando variaveis double para as notas e sua media
double n1, n2, media;

//Greetings!
Console.WriteLine("Bem vindo ao calculador de media de notas da Prof(a) Alexa!");

//Tratamento de erro
while (true)
{
    try
    {
        //Solicitando a primeira nota (e convertendo a variavel para Double)
        Console.Write("Digite a primeira nota: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        break;
    } catch (FormatException ex){Console.WriteLine("Erro! Por favor digite somente valores numericos (Ex: 5.5)");}
}

//Tratamento de erro
while (true)
{
    try
    {
        //Solicitando a segunda nota (e convertendo a variavel para Double)
        Console.Write("Digite a segunda nota: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        break;
    }catch(FormatException ex) {Console.WriteLine("Erro! Por favor digite somente valores numericos (Ex: 5.5)");}
}

//Calculando a media de notas
media = (n1 + n2)/2;

//Imprimindo o resultado
Console.WriteLine($"A media das notas {n1} e {n2} é igual a {media}.");