using NUnit.Framework;
using System;
using System.IO;

namespace NumbersATasks.Tests
{
    [TestFixture]
    public class TasksTests
    {
        private StringWriter writer;

        [SetUp]
        public void SetUp()
        {
            writer = new StringWriter();
            Console.SetOut(writer);
        }

        [TearDown]
        public void Cleanup()
        {
            writer.Close();
        }

        [TestCase(98, "Left digit is 9")]
        [TestCase(52, "Left digit is 5")]
        [TestCase(66, "Left digit is 6")]
        public void Task1_ReturnsCorrectValue(int n, string expected)
        {
            Tasks.Task1(n);
            var actual = writer.GetStringBuilder().ToString().Trim();
            Assert.AreEqual(expected, actual, "Task1 returns incorrect value.");
        }

        [TestCase(68, "Sum = 14, Product = 48")]
        [TestCase(23, "Sum = 5, Product = 6")]
        [TestCase(74, "Sum = 11, Product = 28")]
        public void Task2_ReturnsCorrectValue(int n, string expected)
        {
            Tasks.Task2(n);
            var actual = writer.GetStringBuilder().ToString().Trim();
            Assert.AreEqual(expected, actual, "Task2 returns incorrect value.");
        }

        [TestCase(235, "Sum = 10, Product = 30")]
        [TestCase(456, "Sum = 15, Product = 120")]
        [TestCase(670, "Sum = 13, Product = 0")]
        public void Task3_ReturnsCorrectValue(int n, string expected)
        {
            Tasks.Task3(n);

            var actual = writer.GetStringBuilder().ToString().Trim();
            Assert.AreEqual(expected, actual, "Task3 returns incorrect value.");
        }

        [TestCase(275, "Result is 752")]
        [TestCase(725, "Result is 257")]
        [TestCase(857, "Result is 578")]
        public void Task4_ReturnsCorrectValue(int n, string expected)
        {
            Tasks.Task4(n);

            var actual = writer.GetStringBuilder().ToString().Trim();
            Assert.AreEqual(expected, actual, "Task4 returns incorrect value.");
        }
    }
}
