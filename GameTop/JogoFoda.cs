using System;
using GameTop.Interface;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly iJogador jogador2;
        private readonly iJogador jogador1;
        private readonly iJogador jogador3;
        public JogoFoda(iJogador jogador1, iJogador jogador2, iJogador jogador3)
        {
            this.jogador1 = jogador1;
            this.jogador2 = jogador2;
            this.jogador3 = jogador3;
        }
        public void iniciarJogo()
        {

            System.Console.WriteLine(jogador1.Corre());
            System.Console.WriteLine(jogador1.Chuta());
            System.Console.WriteLine(jogador1.Passe());

            System.Console.WriteLine("------------------------------------------------------------------");

            System.Console.WriteLine(jogador2.Corre());
            System.Console.WriteLine(jogador2.Chuta());
            System.Console.WriteLine(jogador2.Passe());

            System.Console.WriteLine("------------------------------------------------------------------");

            System.Console.WriteLine(jogador3.Corre());
            System.Console.WriteLine(jogador3.Chuta());
            System.Console.WriteLine(jogador3.Passe());

        }

    }

}
