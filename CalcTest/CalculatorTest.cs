using DemoTest040221;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Calculator_Add_SmallNumbers()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            var result = calc.Add(3, 4); // come form DB

            // Assert
            Assert.AreEqual(result, 7); // come form DB
        }
        [TestMethod]
        public void Calculator_Add_LargeNumbers()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            var result = calc.Add(3, 4); // come form DB

            // Assert
            Assert.AreEqual(result, 8); // come form DB
        }

        [TestMethod]
        public void Calculator_Add_Zeros()
        {

            // Arrange
            Calculator calc = new Calculator();

            // Act
            var result = calc.Add(3, 0); // come form DB

            // Assert
            Assert.AreEqual(result, 3); // come form DB
            
        }
    }
}
