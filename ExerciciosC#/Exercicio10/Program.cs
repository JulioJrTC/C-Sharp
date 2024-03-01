//Desafio 10: Crie um programa que leia quanto dinheiro uma pessoa tem na carteira e mostre quantos dólares ela pode comprar.

double cotacaoDolar = 4.95; //1 dolar = 4.95 reais

double carteira;

Console.WriteLine("Bem vindo a carteira da Alexa!");

while (true)
{
    //Solicitando uma quantia monetaria em dolar (que será armazenada em uma variavel 'carteira')
    Console.Write("Digite quantos R$ vc possui: ");
    carteira = Double.Parse(Console.ReadLine());

    //Convertendo Reais para Dolares
    double converter_RpD = carteira / cotacaoDolar;

    //Imprimindo resultado
    Console.WriteLine($"Com R${carteira}, vc pode comprar ${converter_RpD:N2} em dolares.");

    //Sistema de escolha ao usuario
    Console.WriteLine("Deseja continuar? [S/N]");
    string c = Console.ReadLine().ToUpper();
    if (c == "N")
    {
        Console.WriteLine("Obrigado e Volte sempre!");
        break;
    }

}