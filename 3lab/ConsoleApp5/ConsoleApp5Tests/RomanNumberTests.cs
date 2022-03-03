using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
       
            [TestMethod()]
            public void Add()
            {
            var romNum = new RomanNumber(10);
            var romNum1 = new RomanNumber(10);
            var romNum2 = new RomanNumber(15);
            var expected1 = new RomanNumber(20);
            var expected2 = new RomanNumber(25);
            
            RomanNumber actual1 = romNum + romNum1;
            RomanNumber actual2 = romNum + romNum2;
            
            Assert.AreEqual(expected1.ToString(), actual1.ToString());
            Assert.AreEqual(expected2.ToString(), actual2.ToString());

        }
        [TestMethod()]
        public void Sub()
        {
          
            var romNum = new RomanNumber(15);
            var romNum1 = new RomanNumber(5);
            var romNum2 = new RomanNumber(120);
            var expected = new RomanNumber(10);

            RomanNumber actual = romNum - romNum1;

            Assert.AreEqual(expected.ToString(), actual.ToString());
            Assert.ThrowsException<RomanNumberException>(() => (romNum - romNum2));

        }
        [TestMethod()]
        public void Div()
        {
            var romNum = new RomanNumber(15);
            var romNum1 = new RomanNumber(5);
            var romNum2 = new RomanNumber(23);
            var expected = new RomanNumber(3);
            RomanNumber actual = romNum / romNum1;

            Assert.AreEqual(expected.ToString(), actual.ToString());
            Assert.ThrowsException<RomanNumberException>(() => (romNum / romNum2));
        }
        [TestMethod()]
        public void Mul()
        {
            var romNum = new RomanNumber(10);
            var romNum1 = new RomanNumber(2);
            var romNum2 = new RomanNumber(15);
            var expected1 = new RomanNumber(20);
            var expected2 = new RomanNumber(150);
            RomanNumber actual1 = romNum * romNum1;
            RomanNumber actual2 = romNum * romNum2;
    
            Assert.AreEqual(expected1.ToString(), actual1.ToString());
            Assert.AreEqual(expected2.ToString(), actual2.ToString());
        }

        [TestMethod()]
        public void ToStringTest()
        {
           
            RomanNumber romNum = new RomanNumber(10);
            string expected = "X";
           
            string actual = romNum.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CloneTest()
        {
          
            RomanNumber romNum = new RomanNumber(10);
            RomanNumber expected = new RomanNumber(10);
          
            RomanNumber clone = (RomanNumber)romNum.Clone();
            
            Assert.AreEqual(expected.ToString(), clone.ToString());
            Assert.AreNotSame(expected, clone);
        }


        [TestMethod()]
        public void CompareToTest()
        {
       
            RomanNumber romNum = new RomanNumber(4);
            RomanNumber romNum1 = new RomanNumber(4);
            const int expected = 0;
         
            int actual = romNum.CompareTo(romNum1);
   
            Assert.AreEqual(expected, actual);
        }
    }
}