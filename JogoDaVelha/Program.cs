using System;
using System.Threading;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Jogo();
            int n = 1;
            while (n < 10)
            {
                Console.WriteLine(n++);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
