using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest;

namespace UnitTesting
{
    [TestClass]
    public class TestingMethods
    {
        [TestMethod]
        // Testing IsFemale Method
        public void Test_IsFeMaleMethod()
        {
            var obj = new MyClass();
            var result = obj.IsFemale("Bahodirova");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_IsFeMaleMethod_Fail()
        {
            var obj = new MyClass();
            var result = obj.IsFemale("Bahodirov");
            Assert.AreNotEqual(true, result);
        }

        // Testing Add Method
        [TestMethod]
        public void Test_AddMethod()
        {
            var obj = new MyClass();
            var result = obj.Add(10, 15);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void Test_AddMethod_Fail()
        {
            var obj = new MyClass();
            var result = obj.Add(10, 10);
            Assert.AreNotEqual(25, result);
        }

        //Testing Multiply Method
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            var obj = new MyClass();
            var result = obj.Multiply(5, 9);
            Assert.AreEqual(45, result);
        }
        [TestMethod]
        public void Test_MultiplyMethod_Fail()
        {
            var obj = new MyClass();
            var result = obj.Multiply(5, 9);
            Assert.AreNotEqual(40, result);
        }
    }
}
