using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void DeleteEmptySpacesBeginEnd()
        {
            var input = "   Kerem   ";
            var output = "Kerem";

            var value = StringHelper.DeleteEmptySpaces(input);

            Assert.AreEqual(output, value);
        }


        [TestMethod]
        public void DeleteEmptySpacesInterior()
        {
            var input = " K  e  r  e  m ";
            var output = "Kerem";

            var value = StringHelper.DeleteEmptySpaces(input);

            Assert.AreEqual(output, value);
        }
    }
}
