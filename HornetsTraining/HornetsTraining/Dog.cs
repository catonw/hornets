namespace HornetsTraining
{
    public class Dog
    {
        private int legscount;
        protected double weight;
        public string name;

        public void feed()
        {
            weight++;
        }

        public int getlegscount()
        {
           return legscount;
        }

        public void modifyanaderanimal(Dog dog)
        {
            dog.legscount = 4;
           // this.legscount
        }
    }

}