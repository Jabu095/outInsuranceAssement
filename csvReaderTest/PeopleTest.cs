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
    public class PersonTest
    {
        [TestMethod]
        public  void intialiseObjectPerson()
        {
            var person = new Person() { FirstName = "jabulani", LastName = "Dube", Address="Jorg", PhoneNumber=090343940};
            var expected = person.FirstName;

            Assert.AreEqual(expected, "jabulani");
        }
    }
}
