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
        public void Format_DoubleOperator_Error04Returned()
        {
            Analaizer.expression = "(10++2)";
            Assert.AreEqual(Analaizer.expression.Substring(0, "Error 04".Length), "Error 04");
        }
       
        
       
    }
}
