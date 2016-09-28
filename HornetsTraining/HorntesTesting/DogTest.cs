using HornetsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HorntesTesting
{
    [TestClass]
    public class DogTest
    {
        [TestMethod]
        public void Doglegscounttest()
        {
            Dog dogs = new Dog();
            dogs.name = "reks";
            dogs.feed();
            dogs.getlegscount();
        }
    }
}