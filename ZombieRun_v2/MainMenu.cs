using System;

//prima voce 21

namespace ZombieRun_v2
{
    class MainMenu
    {

        //METODI PUBBLICI
        public MainMenu()
        {
            Console.CursorVisible = false;
            runMenu = true;
            voce = 0;
            game = new ZombiRun();
        }

        //esegue il menu
        public void Run()
        {
            Loop();
            runMenu = true;
        }



        //METODI PRIVATI
        private void Loop()
        {
            StampaScritta();
            while(runMenu == true)
            {
                StampaVoci();
                InputMenu();
            }
        }

        //gestisce l'input del menu
        private void InputMenu()
        {
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:
                    UpArrow();
                    break;
                case ConsoleKey.DownArrow:
                    DownArrow();
                    break;
                case ConsoleKey.Enter:
                    Enter();
                    break;
            }
        }

        //stampa le voci del menu
        private void StampaVoci()
        {
            NuovaPartita();
            Difficolta();
            Esci();
        }

        //stampa la prima voce
        private void NuovaPartita()
        {
            Console.SetCursorPosition(50, 21);
            if (voce == 0)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.White;
            Console.Write("NUOVA PARTITA");
        }

        //stampa la seconda voce
        private void Difficolta()
        {
            Console.SetCursorPosition(51, 23);
            if (voce == 1)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.White;
            Console.Write("DIFFICOLTA'");
        }

        //stampa la terza voce
        private void Esci()
        {
            Console.SetCursorPosition(54, 25);
            if (voce == 2)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ESCI");
        }

        //stampa la scritta principale
        private void StampaScritta()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 2);
            Console.Write(scritta);
        }


        //COMANDI
        //UpArrow
        private void UpArrow()
        {
            if (voce == 0)
                voce = 3;
            --voce;
        }

        //DownArrow
        private void DownArrow()
        {
            if (voce == 2)
                voce = -1;
            ++voce;
        }

        //Enter
        private void Enter()
        {
            switch(voce)
            {
                case 0:
                    game.Run();
                    Console.Clear();
                    StampaScritta();
                    break;
                case 1:
                    break;
                case 2:
                    runMenu = false;
                    break;
            }
        }


        //MEMBRI PRIVATI
        private bool runMenu;
        private sbyte voce;
        private ZombiRun game;
        private const string scritta = @"  
                           ████████      ███     ██   ██    ████     █   ██ ███
                                 █      █   █   █  █ █  █    █  █       ██ █
                                █       █   █    █  █  █    █████    █   █
                               █         ███    █       █    █   █   ██  ████
                             ██████████        ██       ██  ██  █    █  ██     █
                                                             ███    ██   █  ███ 
                                       ████                               ██   
                                       █ █ ███ 
                                       █      █  ██    ███  █████   ███
                                       ██    █     █    █ █   █ █    █
                                       █   █       █   █     █  █     █
                                       ██ ██       █   █     █   █   █
                                       █  █        █   █      █   █  █ 
                                       █   ██       ████     █     █ █
                                       ██    ██              ███    ███";
    }
}
