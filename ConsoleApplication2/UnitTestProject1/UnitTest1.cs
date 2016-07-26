using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Program programTestVariable = new Program();
        [TestMethod]
        public void TestAddition()
        {
            programTestVariable.Addition(2, 2);
        }
        [TestMethod]
        public void TestSubtract()
        {
            programTestVariable.Subtraction(2, 2);
        }
        [TestMethod]
        public void TestMultiplication()
        {
            programTestVariable.Multiplication(2, 2);
        }
        [TestMethod]
        public void TestDivision()
        {
            programTestVariable.Division(2, 2);
        }

    }
}
