using csvReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvReaderTest
{
    [TestClass]
    public class MainMethodTest
    {
        [TestMethod]
        public void SortReapingNames()
        {
            var main = new MainReader();
            main.SortReapingNames(new List<Person>() { new Person() { FirstName ="jabulani", LastName = "Dube", Address = "Jorg", PhoneNumber = 09893898349 } });
            Assert.IsNotNull(main);
        }

        [TestMethod]
        public void SortAddress()
        {
            var main = new MainReader();
            main.Address(new List<Person>() { new Person() { FirstName = "jabulani", LastName = "Dube", Address = "25 Jorg", PhoneNumber = 09893898349 } });
            Assert.IsNotNull(main);
        }

        [TestMethod]
        public void SortFirstNames()
        {
            var main = new MainReader();
            main.FirstLastName(new List<Person>() { new Person() { FirstName = "jabulani", LastName = "Dube", Address = "Jorg", PhoneNumber = 09893898349 } });
            Assert.IsNotNull(main);
        }
    }
}
