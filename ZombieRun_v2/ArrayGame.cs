using System.Collections.Generic;

namespace ZombieRun_v2
{
    abstract class ArrayGame
    {
        //MEMBRI PUBBLICI 
        //costruttore
        public ArrayGame()
        {
            vettore = new List<Sprite>();
        }

        //get Count
        public int Count
        {
            get
            {
                return vettore.Count;
            }
        }



        //MEMBRI PUBBLICI ABSTRACT
        public abstract void Move();



        //MEMBRI PROTECTED
        //get index
        protected Sprite this[int index]
        {
            get
            {
                return vettore[index];
            }
        }



        //MEMBRI PROTECTED
        protected List<Sprite> vettore;
    }
}
