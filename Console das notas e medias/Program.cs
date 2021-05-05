using System;

namespace Console_das_notas_e_medias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Da média");
            
            Console.WriteLine("Qual a primeira nota?");
            Double primeiranota = Double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a segunda nota?");
            Double segundanota = Double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a terceira nota?");
            Double terceiranota = Double.Parse(Console.ReadLine());

            Double media = (primeiranota + segundanota + terceiranota) / 3;
            Console.WriteLine("A media foi de: " + media.ToString("N1"));

            if(media >5)
            {
            //    Se a media do aluno for maior que 5 ele é aprovado
            Console.WriteLine("O Aluno foi aprovado!!Congratulations!");
            } else {

            //    se a media do aluno for menor que 5 ele é reprovado
            Console.WriteLine("O Aluno foi reprovado Sinto muito");
            }

        }
    }
}
