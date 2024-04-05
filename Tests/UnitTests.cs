using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(5, Program.Subtract("6", "1"));
            Assert.AreEqual(0, Program.Subtract("2", "2"));
            Assert.AreEqual(-1, Program.Subtract("4", "5"));
        }

        [Test]
        public void Subtract_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("9", "c"));
            Assert.Throws<FormatException>(() => Program.Subtract("c", "9"));
            Assert.Throws<FormatException>(() => Program.Subtract("c", "c"));
        }

        [Test]
        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("0", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "0"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(0, Program.Multiply("0", "1"));
            Assert.AreEqual(7, Program.Multiply("7", "1"));
            // intentionally make this case fail
            Assert.AreEqual(6, Program.Multiply("-2", "3"));
        }

        [Test]
        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("13", "j"));
            Assert.Throws<FormatException>(() => Program.Multiply("j", "13"));
            Assert.Throws<FormatException>(() => Program.Multiply("m", "n"));
        }

        [Test]
        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("3", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "3"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(0, Program.Power("0", "1"));
            Assert.AreEqual(1, Program.Power("9", "0"));
        }

        [Test]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Power("4", "i"));
            Assert.Throws<FormatException>(() => Program.Power("j", "13"));
            Assert.Throws<FormatException>(() => Program.Power("m", "n"));
        }

        [Test]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("3", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "3"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
