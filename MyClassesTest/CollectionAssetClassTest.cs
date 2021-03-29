using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class CollectionAssetClassTest:TestBase
    {
        [TestMethod]
        public void AareCollectionsEqual()
        {
            PersonManager personManager = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Anar", LastName = "Baydamirov" });
            peopleExpected.Add(new Person() { FirstName = "Elmir", LastName = "Misha" });
            peopleExpected.Add(new Person() { FirstName = "John", LastName = "Doe" });

            peopleActual = personManager.GetPeople();

            CollectionAssert.AreEqual(peopleExpected, peopleActual);
        }

        [TestMethod]
        public void IsCollectionOfTypeTest()
        {
            PersonManager personManager = new PersonManager();
            List<Person> peopleActual = new List<Person>();

            peopleActual = personManager.GetSupervisors();

            CollectionAssert.AllItemsAreInstancesOfType(peopleActual, typeof(Supervisor));
        }
    }
}
