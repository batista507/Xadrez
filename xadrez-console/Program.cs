using System;
using tabuleiro;
using Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez Partida = new PartidaDeXadrez();

                while (!Partida.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirTabuleiro(Partida.Tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + Partida.Turno);
                        Console.WriteLine("Aguardando jogada: " + Partida.jogadorAtual);

                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        Partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = Partida.Tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(Partida.Tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        Partida.validarPosicaoDeDestino(origem, destino);

                        Partida.RealizaJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
