// Desafio 13: Faça um algoritmo que leia o salário de um funcionário e mostre seu novo salário, com 15% de aumento.

//Solicitando o nome do funcionario
Console.Write("Digite o nome do funcionario: ");
string nomeFuncionario = Console.ReadLine();

//Solicitando o salario atual do funcionario
Console.Write("Digite seu salario atual: R$");
double salarioAtual = Convert.ToDouble(Console.ReadLine());

//Solicitando em quantos % será o aumento
Console.Write("Quanto será o aumento: (Exemplo '5' para 5% de aumento): ");
int aumento = Convert.ToInt32(Console.ReadLine());

//Calculando novo salario
double novoSalario = salarioAtual+(salarioAtual * aumento / 100);

//Imprimindo novo salario
Console.WriteLine($"Parabens {nomeFuncionario}! Seu salario que antes era R${salarioAtual:N2}, com {aumento}% de aumento, seu novo salario será R${novoSalario:N2}!");