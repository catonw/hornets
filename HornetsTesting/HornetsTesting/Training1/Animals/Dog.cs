namespace HornetsTesting.Training1.Animals
{
    public class Dog
    {
        private int legs;
        protected int wer;
        public string name;

        public void getlegs()
        {
            legs = 12;

        }

        public string setname()
        {
            name = "jas";
            return name;
        }

        public void getclass(Dog Dog)
        {
            Dog.legs = 4;
        }
    }
}