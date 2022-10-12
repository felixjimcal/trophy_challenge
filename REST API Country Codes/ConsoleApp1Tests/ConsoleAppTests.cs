using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Tests
{
    [TestClass()]
    public class ConsoleAppTests
    {
        [TestMethod()]
        public void NoCountry()
        {
            //arrange
            var country = "";
            var phoneNumber = 666999666;

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(country);
            Console.SetIn(stringReader);

            //act
            Answer.GetPrefix(country, phoneNumber);

            //assert
            var outputLines = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("-1", outputLines[0]);
        }

        [TestMethod()]
        public void NoExistingCountry()
        {
            //arrange
            var country = "Oceania";
            var phoneNumber = 666999666;

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(country);
            Console.SetIn(stringReader);

            //act
            Answer.GetPrefix(country, phoneNumber);

            //assert
            var outputLines = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("-1", outputLines[0]);
        }

        [TestMethod()]
        public void HaveCountry()
        {
            //arrange
            var country = "Spain";
            var phoneNumber = 123;

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(country);
            Console.SetIn(stringReader);

            //act
            Answer.GetPrefix(country, phoneNumber);

            //assert
            var outputLines = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("+34 123", outputLines[0]);
        }
    }
}