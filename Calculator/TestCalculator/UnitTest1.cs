using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcClas;
using AnalaizerClass;
using System.Collections;
using System.Windows.Forms;

namespace TestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckCurrency_WrongParenthesis_Error01()
        {
            Analaizer.expression = "(10+10";
            Assert.AreEqual(Analaizer.CheckCurrency(), false);
        }
        
        [TestMethod]
        public void Format_UnknownOperator_Error02()
        {
            Analaizer.expression = "(10$10)";

            Assert.AreEqual(Analaizer.Format(), Calculator.lastError);
        }
        [TestMethod]
        public void CreateStack_SyntaxError_Error03()
        {
            Analaizer.expression = "(5(+1))";
            
            Assert.AreEqual(Analaizer.CreateStack().Count,0);
        }
        [TestMethod]
        public void CreateStack_DoubleOperator_Error04Returned()
        {
            Analaizer.expression = "(10++2)";
            ArrayList array= Analaizer.CreateStack();
            
            Assert.AreEqual(array, null);
            
        }
        


    }
}
