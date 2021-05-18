using Microsoft.VisualStudio.TestTools.UnitTesting;
using roman2arabig;
using System;
using System.Collections.Generic;
using System.Text;

namespace roman2arabig.Tests
{
    [TestClass()]
    public class mathOpsTests
    {

        [TestMethod()]
        public void roman_to_intTest_I()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("I"),1);
        }
        [TestMethod()]
        public void roman_to_intTest_II()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("II"), 2);
        }
        [TestMethod()]
        public void roman_to_intTest_III()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("III"), 3);
        }


        [TestMethod()]
        public void roman_to_intTest_V()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("V"), 5);
        }

        [TestMethod()]
        public void roman_to_intTest_X()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("X"), 10);
        }
        [TestMethod()]
        public void roman_to_intTest_XX()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("XX"), 20);
        }
        [TestMethod()]
        public void roman_to_intTest_XXX()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("XXX"), 30);
        }

        [TestMethod()]
        public void roman_to_intTest_L()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("L"), 50);
        }
        [TestMethod()]
        public void roman_to_intTest_C()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("C"), 100);
        }
        [TestMethod()]
        public void roman_to_intTest_CC()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("CC"), 200);
        }
        [TestMethod()]
        public void roman_to_intTest_CCC()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("CCC"), 300);
        }
        [TestMethod()]
        public void roman_to_intTest_D()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("D"), 500);
        }
        [TestMethod()]
        public void roman_to_intTest_M()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("M"), 1000);
        }
        [TestMethod()]
        public void roman_to_intTest_MM()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("MM"), 2000);
        }
        [TestMethod()]
        public void roman_to_intTest_MMM()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("MMM"), 3000);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Incorrect format")]
        public void IncorrectFormat_Empty()
        {
            var x = new roman2arabig.mathOps();
            x.roman_to_Int("");
        }

        [TestMethod()]
        public void roman_to_intTest_IV()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("IV"), 4);
        }

        [TestMethod()]
        public void roman_to_intTest_IX()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("IX"), 9);
        }
        [TestMethod()]
        public void roman_to_intTest_XL()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("XL"), 40);
        }
        [TestMethod()]
        public void roman_to_intTest_XC()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("XC"), 90);
        }
        [TestMethod()]
        public void roman_to_intTest_CD()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("CD"), 400);
        }
        [TestMethod()]
        public void roman_to_intTest_CM()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("CM"), 900);
        }
        [TestMethod()]
        public void roman_to_intTest_XXI()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("XXI"), 21);
        }
        [TestMethod()]
        public void roman_to_intTest_LVIII()
        {
            var x = new roman2arabig.mathOps();
            Assert.AreEqual(x.roman_to_Int("LVIII"), 58);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Incorrect format")]

        public void IncorrectFormat_VX()
        {
            var x = new roman2arabig.mathOps();
            x.roman_to_Int("VX");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Incorrect format")]
        public void IncorrectFormat_LC()
        {
            var x = new roman2arabig.mathOps();
            x.roman_to_Int("LC");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Incorrect format")]
        public void IncorrectFormat_DM()
        {
            var x = new roman2arabig.mathOps();
            x.roman_to_Int("DM");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Incorrect format")]
        public void IncorrectFormat_LL()
        {
            var x = new roman2arabig.mathOps();
            x.roman_to_Int("LL");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Incorrect format")]
        public void IncorrectFormat_DD()
        {
            var x = new roman2arabig.mathOps();
            x.roman_to_Int("DD");
        }
    }
}