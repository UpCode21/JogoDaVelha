using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class Jogo
    {
        Jogador jogador1;
        Jogador jogador2;
        Char[,] matrizSimbolos = new Char[3, 3]{
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' }
            };
        int turno = 1;


        public Jogo()
        {
            msgBoasVindas();
            defineJogadores();
            mostraTela();
        }

        public void msgBoasVindas()
        {
            Console.WriteLine("The Old's Game");
        }

        // nome e símbolo
        public void defineJogadores()
        {
            jogador1 = new Jogador();
            jogador2 = new Jogador();

            Console.WriteLine("Definindo jogadores...");
            Console.Write("Olá Jogador 1. Qual é o seu nome?");
            jogador1.Nome = Console.ReadLine();

            Console.Write("Olá Jogador 1. Qual é o seu símbolo?");
            jogador1.Simbolo = Char.Parse(Console.ReadLine());

            Console.Write("Olá Jogador 2. Qual é o seu nome?");
            jogador2.Nome = Console.ReadLine();

            Console.Write("Olá Jogador 2. Qual é o seu símbolo?");
            jogador2.Simbolo = Char.Parse(Console.ReadLine());

        }

        public void mostraTela()
        {
            Console.WriteLine($"Turno {turno}");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(matrizSimbolos[linha, coluna]);
                    if (coluna < 2) Console.Write("|");
                }
                if (linha < 2) Console.WriteLine("\n- - -");
            }
        }
    }
}
