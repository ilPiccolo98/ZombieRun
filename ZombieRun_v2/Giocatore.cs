using System;

namespace ZombieRun_v2
{
    class Giocatore : Sprite
    {
        //METODI PUBBLICI
        //costruttore
        public Giocatore(int x, int y) : base(x, y, '☺', ConsoleColor.White) 
        {

        }

        //sposta il giocatore a seconda della direzione inserita
        public override void Move(Direzione d)
        {
            Cancella();
            switch(d)
            {
                case Direzione.UP:
                    --x;
                    break;
                case Direzione.DOWN:
                    ++x;
                    break;
            }
            Stampa();
        }

    }
}
