using System;

namespace ZombieRun_v2
{
    class Proiettile : Sprite
    {
        //METODI PUBBLICI
        //costruttore
        public Proiettile(int x, int y) : base(x, y, '+', ConsoleColor.Cyan)
        {

        }

        //cancella e distrugge il proiettile
        public void Distruggi()
        {
            Cancella();
            y = 0;
        }

        //sposta il proiettile a seconda della direzione inserita
        public override void Move(Direzione d)
        {
            Cancella();
            switch(d)
            {
                case Direzione.UP:
                    --x;
                    break;
                case Direzione.LEFT:
                    --y;
                    break;
                case Direzione.DOWN:
                    ++x;
                    break;
                case Direzione.RIGHT:
                    ++y;
                    break;
            }
            Stampa();
        }
    }
}
