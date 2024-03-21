// Desafio 19: Um professor quer sortear um dos seus quatro alunos para apagar o quadro. Faça um programa que ajude ele, lendo o nome deles e escrevendo o nome do escolhido. //

//Usando da biblioteca abaixo para criarmos uma ArrayList
using System.Collections;

//Usando da biblioteca abaixo para efetuarmos tratamentos de erros
using System.Text.RegularExpressions;

//Criando uma nova lista array que irá conter os nomes dos alunos
ArrayList alunosLista = new ArrayList();

//Greetings!
Console.WriteLine("Bem vindo ao escolhedor de aluno(a) aleatorio da prof(a) Alexa Blessings!\n");

//Usando um loop FOR que irá solicitar e adicionar a lista acima o nome de 4 alunos
for (int i = 0; i < 4; i++)
{
    //Tratamento de erro
    while (true)
    {    
        Console.Write($"Insira o nome do {i + 1}º aluno: ");
        string alunoNome = Console.ReadLine();
        
        if (!Regex.IsMatch(alunoNome, "[A-Za-z]"))
        {
            Console.WriteLine("Erro! Não digite valores alem de palavras!");
        }else{
            alunosLista.Add(alunoNome);
            break;
        }
    }
}

//Imprimindo os nomes dos alunos de acordo com o index da lista array
Console.WriteLine("\nAlunos cadastrados:");
for (int i = 0; i < alunosLista.Count; i++)
{
    Console.WriteLine($"{i} = {alunosLista[i]}");
}

//Usando da biblioteca Random para o sistema escolher um numero de 0 a 3
Random numeroAleatorio = new Random();
int indexAleatorio = numeroAleatorio.Next(0, 4);

//Imprimindo o nome do aluno(a) escolhido
Console.WriteLine($"\nO(a) aluno(a) escolhido para apagar o quadro foi: {alunosLista[indexAleatorio]}");