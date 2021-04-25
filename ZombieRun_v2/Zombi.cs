using System;

namespace ZombieRun_v2
{
    class Zombi : Sprite
    {
        //METODI PUBBLICI
        //costruttore
        public Zombi(int x, int y) : base(x, y, '☻', ConsoleColor.Green)
        {

        }

        //sposta lo zombi a seconda della direzione inserita
        public override void Move(Direzione d)
        {
            Cancella();
            switch(d)
            {
                case Direzione.LEFT:
                    --y;
                    break;
                case Direzione.RIGHT:
                    ++y;
                    break;
            }
            Stampa();
        }
    }
}
