using System;

namespace exemplo_console
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Qual seu nome?");
           string nomePessoa = Console.ReadLine();

           Console.WriteLine("Saldações Humano " + nomePessoa + "!!");

            Console.WriteLine("Qual é o primeiro numero?");
            // Qual o estado do semaforo
            int primeironumero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual é o segundo numero?");
            int segundonumero = int.Parse(Console.ReadLine());

            int soma = primeironumero +  segundonumero;

            Console.WriteLine("A soma dos numeros foi: " + soma);
        }
    }
}
