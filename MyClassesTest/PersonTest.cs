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
    public class PersonTest : TestBase
    {
        [TestMethod]
        public void IsInstanceOfTypeTest()
        {
            PersonManager personManager = new PersonManager();
            Person person;

            person = personManager.CreatePerson("John", "Doe", true);

            Assert.IsInstanceOfType(person, typeof(Supervisor));
        }

        [TestMethod]
        public void IsNullTest()
        {
            PersonManager personManager = new PersonManager();
            Person person;

            person = personManager.CreatePerson("", "Doe", true);

            Assert.IsNull(person);
        }
    }
}
