using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Desafio 01: Crie um programa que escreva "Olá, Mundo!" na tela.

namespace ExerciciosCSharp
{
    internal class Exercicio01
    {
        public static void Main(String[] args)
        {
            //Declarando uma variavel String
            String nomePessoa = "Alexa Bliss";

            //Imprimindo uma frase junto a uma variavel
            Console.WriteLine("Hello " + nomePessoa + "!");
        }
    }
}
