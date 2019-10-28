using System;

namespace teste_git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo");
            Console.WriteLine("Olá Sr. Djalma");
            Console.WriteLine("Como vai você?");
            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Olá Djalma, vejo que você tem " + idade + " anos. Parabéns.");
        }
    }
}
