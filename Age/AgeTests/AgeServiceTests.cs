using Microsoft.VisualStudio.TestTools.UnitTesting;
using exo1_age.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Age;

namespace exo1_age.Program.Tests
{
    [TestClass()]
    public class AgeServiceTests
    {
        [TestMethod()]
        public void CalculAgeAnjara()
        {
            string ageInput = "05/06/2004";

            AgeService service = new AgeService();
            int actual = service.calculAge(ageInput);

            int expected = 19;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculAgeEtienne()
        {
            string ageInput = "04/09/1980";

            AgeService service = new AgeService();
            int actual = service.calculAge(ageInput);

            int expected = 43;
            Assert.AreEqual(expected, actual);
        }
    }
}