
namespace ZombieRun_v2
{
    class Caricatore : ArrayGame
    {
        //METODI PUBBLICI
        //costruttore
        public Caricatore() : base()
        {

        }

        //get index
        public new Proiettile this[int index]
        {
            get
            {
                return (vettore[index] as Proiettile);
            }
        }

        //aggiunge un colpo
        public void Aggiungi()
        {
            vettore.Add(new Proiettile(0, 0));
        }

        //spara un proiettile se è disponibile
        public void Shoot(int x, int y)
        {
            foreach (var i in vettore)
                if (i.Y == 0)
                {
                    i.ChangePosition(x, y);
                    break;
                }
        }

        //muove tutti i proiettile se è possibile
        public override void Move()
        {
            foreach (var i in vettore)
            {
                if (i.Y != 0)
                    i.Move(Direzione.LEFT);
                else
                {
                    Proiettile temp = (i as Proiettile);
                    temp.Distruggi();
                }
            }
        }
    }
}
