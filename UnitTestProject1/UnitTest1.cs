using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_to_Laba2._3_a_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] myArr = { 18, 3, -8, 0, 4, -2, 7 };
            int dob = Laba2._3.Program.Dobutok(myArr);
            int sum = Laba2._3.Program.Suma(myArr);
            Assert.AreEqual(24192, dob);
            Assert.AreEqual(13, sum);
        }
    }
}
