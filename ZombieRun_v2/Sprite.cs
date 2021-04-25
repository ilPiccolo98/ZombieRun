using System;
using System.Text;

namespace ZombieRun_v2
{
    abstract class Sprite
    {
        //METODI PUBBLICI
        //costruttore
        public Sprite(int x, int y, char skin, ConsoleColor colore)
        {
            this.x = x;
            this.y = y;
            Skin = skin;
            this.colore = colore;
        }



        //MEMBRI NON ASTRATTI
        //get x
        public int X
        {
            get
            {
                return x;
            }
        }

        //get y
        public int Y
        {
            get
            {
                return y;
            }
        }

        //get set colore
        public ConsoleColor Colore
        {
            get
            {
                return colore;
            }
            set
            {
                colore = value;
            }
        }

        //stampa la skin
        public void Stampa()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = colore;
            Console.SetCursorPosition(y, x);
            Console.Write(Skin);
        }

        //cancella la skin
        public void Cancella()
        {
            Console.SetCursorPosition(y, x);
            Console.Write('\0');
        }

        //cambia la posizione dello sprite
        public void ChangePosition(int x, int y)
        {
            Cancella();
            this.x = x;
            this.y = y;
            Stampa();
        }



        //MEMBRI ASTRATTI
        //sposta lo sprite in una direzione
        public abstract void Move(Direzione d);


        //MEMBRI PROTECTED
        protected int x;
        protected int y;
        protected char Skin { get; }
        //MEMBRI PRIVATI
        private ConsoleColor colore;
    }
}
