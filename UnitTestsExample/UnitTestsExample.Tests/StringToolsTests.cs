using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsExample.Tests
{
    [TestClass]
    public class StringToolsTests
    {
        [TestMethod]
        public void InsertInto_Should_Insert_FILM_in_5th_pos()
        {
            //arrange
            string orig = "New Star Wars";
            string inserted = "Film ";
            string expected = "New Film Star Wars";
            string actual = "";
            int pos = 5;
            StringTools stringTools = new StringTools(orig);

            //act
            actual = stringTools.InsertInto(pos, inserted);

            //assert
            Assert.AreEqual(expected, actual, "Failed. Expected string is ({0}), but actual is ({1})", expected, actual);
        }

        [TestMethod]
        public void InsertInto_Should_return_empty_string_when_position_is_out_of_range()
        {
            //arrange
            string orig = "New Star Wars";
            string inserted = "Film ";
            string expected = "";
            string actual = "";
            int pos = 105;
            StringTools stringTools = new StringTools(orig);

            //act
            actual = stringTools.InsertInto(pos, inserted);

            //assert
            Assert.AreEqual(expected, actual, "Failed. Expected string is ({0}), but actual is ({1})", expected, actual);
        }
    }
}
