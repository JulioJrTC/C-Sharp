//Desafio 03: Crie um programa que leia dois numeros e mostre a soma entre eles.

//Greetings!
Console.WriteLine("Bem vindo ao somador da Prof(a) Alexa!");

//Programa principal
while (true)
{
    //Solicitando um valor numerico que será armazenando em uma variavel string
    Console.Write("Digite o primeiro numero: ");
    var input1 = Console.ReadLine();

    //Se não for possivel converter a variavel String para Int iremos exibir um erro (e se for, iremos armazenar o valor convertido em uma variavel Int)
    if (!int.TryParse(input1, out int n1))
    {
        Console.WriteLine("Erro! Digite um valor numerico valido!");
        return;
    }

    //Solicitando um valor numerico que será armazenando em uma variavel string
    Console.Write("Digite o segundo numero: ");
    var input2 = Console.ReadLine();

    //Se não for possivel converter a variavel String para Int iremos exibir um erro (e se for, iremos armazenar o valor convertido em uma variavel Int)
    if (!int.TryParse(input2, out int n2))
    {
        Console.WriteLine("Erro! Digite um valor numerico valido!");
        return;
    }

    //Variavel que irá conter a soma dos valores inseridos nas variaveis anteriores
    int soma = (n1 + n2);

    //Imprimindo resultado
    Console.WriteLine($"{n1} + {n2} = {soma}");

    //Variavel para o sistema de escolhas
    string c;

    //Tratamento de erro
    while (true)
    {
        Console.Write("Deseja continuar? [S/N]");
        c = Console.ReadLine().ToUpper();

        if (c=="N" || c=="S"){
            break;
        }
        else
        {
            Console.WriteLine("Erro! Digite S para continuar ou N para sair do programa!");
        }
    }
    
    if (c=="N")
    {
        Console.WriteLine("Obrigado e volte sempre!");
        break;
    }
}