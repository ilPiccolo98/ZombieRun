
namespace ZombieRun_v2
{
    class ZombiArray : ArrayGame
    {
        //METODI PUBBLICI
        //costruttore
        public ZombiArray()
        {

        }

        //get index
        public new Zombi this[int index]
        {
            get
            {
                return (vettore[index] as Zombi);
            }
        }

        //aggiunge e stampa uno zombi
        public void Aggiungi(int x, int y)
        {
            vettore.Add(new Zombi(x, y));
        }

        //stampa l'ultimo zombi aggiunto
        public void PrintLast()
        {
            vettore[vettore.Count - 1].Stampa();
        }

        //muove gli zombi
        public override void Move()
        {
            foreach (var i in vettore)
                i.Move(Direzione.RIGHT);
        }
    }
}
