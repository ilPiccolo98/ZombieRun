using System;
using System.Threading;

//tot righe console = 29

namespace ZombieRun_v2
{
    class ZombiRun
    {
        //METODI PUBBLICI
        //costruttore
        public ZombiRun()
        {
            Init();
            Console.CursorVisible = false;
            zombi.Aggiungi(r.Next(0, 29), 0);
            InitColpi();
        }

        //esegue il gioco
        public void Run()
        {
            Loop();
            Init();
            zombi.Aggiungi(r.Next(0, 29), 0);
            InitColpi();
        }



        //METODI PRIVATI
        //loop del gioco
        private void Loop()
        {
            StampaElementi();
            while(runGame == true)
            {
                Collisioni();
                InputGame();
                caricatore.Move();
                Collisioni();
                zombi.Move();
                GameOver();
                Thread.Sleep(150);
            }
        }

        //gestisce l'input del gioco
        private void InputGame()
        {
            if(Console.KeyAvailable == true)
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        W();
                        break;
                    case ConsoleKey.S:
                        S();
                        break;
                    case ConsoleKey.Spacebar:
                        Spacebar();
                        break;
                    case ConsoleKey.Escape:
                        Escape();
                        break;
                }
        }

        //stampa gli elementi del gioco
        private void StampaElementi()
        {
            Console.Clear();
            Utility.StampaMuro(giocatore.Y - 2, 30, ConsoleColor.White);
            giocatore.Stampa();
        }

        //controlla le collisioni tra zombi e colpi
        private void Collisioni()
        {
            for (int i = 0; i != zombi.Count; ++i)
            {
                for (int y = 0; y != caricatore.Count; ++y)
                    if (Utility.Collisione(zombi[i], caricatore[y]) == true)
                    {
                        caricatore[y].Distruggi();
                        zombi[i].ChangePosition(r.Next(0, 29), 0);
                        ++punteggio;
                        CheckPunteggio();
                    }
            }
        }

        //controlla il punteggio
        private void CheckPunteggio()
        {
            if(punteggio % 5 == 0)
            {
                caricatore.Aggiungi();
                zombi.Aggiungi(r.Next(0, 29), 0);
                zombi.PrintLast();
            }
        }

        //controlla se gli zombi oltrepassano il muro
        private void GameOver()
        {
            for(int i = 0; i != zombi.Count; ++i)
                if(zombi[i].Y == giocatore.Y - 2)
                {
                    zombi[i].Colore = ConsoleColor.Red;
                    zombi[i].Stampa();
                    Utility.StampaMessaggio($"GAME OVER! -> Punteggio: {punteggio}", 14, 40, ConsoleColor.Red);
                    runGame = false;
                }
        }

        //inizializza i membri della classe
        private void Init()
        {
            runGame = true;
            punteggio = 1;
            r = new Random();
            giocatore = new Giocatore(15, 110);
            zombi = new ZombiArray();
            caricatore = new Caricatore();
        }

        //inizializza i colpi
        private void InitColpi()
        {
            for (int i = 0; i != 2; ++i)
                caricatore.Aggiungi();
        }



        //COMNADI
        //W
        private void W()
        {
            if (giocatore.X != 0)
                giocatore.Move(Direzione.UP);
        }

        //S
        private void S()
        {
            if (giocatore.X != 29)
                giocatore.Move(Direzione.DOWN);
        }

        //Spacebar
        private void Spacebar()
        {
            caricatore.Shoot(giocatore.X, giocatore.Y - 3);
        }

        //Escape
        private void Escape()
        {
            runGame = false;
        }



        //MEMBRI PRIVATI
        private bool runGame;
        private long punteggio;
        private Random r;
        private Giocatore giocatore;
        private ZombiArray zombi;
        private Caricatore caricatore;
    }
}
