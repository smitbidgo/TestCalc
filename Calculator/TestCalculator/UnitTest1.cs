using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcClas;
using AnalaizerClass;
namespace TestCalculator
{
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
        public void Format_UnknownOperator_Error02Returned()
        {
            Analaizer.expression = "(10$2)";
            Assert.AreEqual(Analaizer.Format(),Calculator.lastError);
        }
    }
}
