using System;

namespace ZombieRun_v2
{
    static class Utility
    {
        //controlla se c'è collisione tra due sprite
        public static bool Collisione(Sprite a, Sprite b)
        {
            if (a.X == b.X && a.Y == b.Y)
                return true;
            return false;
        }

        //stampa un muro
        public static void StampaMuro(int y, int limiteX, ConsoleColor colore)
        {
            Console.ForegroundColor = colore;
            for(int x = 0; x != limiteX; ++x)
            {
                Console.SetCursorPosition(y, x);
                Console.Write('█');
            }
        }

        //stampa un messaggio
        public static void StampaMessaggio(string text, int x = 0, int y = 0, ConsoleColor colore = ConsoleColor.White)
        {
            Console.ForegroundColor = colore;
            Console.SetCursorPosition(y, x);
            Console.Write(text);
            Console.SetCursorPosition(y, x + 1);
            Console.Write("Premere INVIO per continuare");
            Console.ReadLine();
        }
    }
}
