using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TestLibDll
{
    [TestFixture]
    public class Tests
    {
        [DllImport(@"C:\Users\Johan\RiderProjects\MiniMath\MiniMath\bin\Debug\MiniMath.dll")]
        public static extern double Plus(double a, double b);
        
        [Test]
        public void TestingPlus()
        {
            double expected = 10.00;
            Assert.AreEqual(expected, MiniMath.MiniMath.Plus(6,4));
        }
        
        [Test]
        public void TestingMinus()
        {
            double expected = 10.00;
            Assert.AreEqual(expected, MiniMath.MiniMath.Minus(20,10));
        }
        
        [Test]
        public void TestingMultiply()
        {
            double expected = 200;
            Assert.AreEqual(expected, MiniMath.MiniMath.Multiply(20,10));
        }
        
        [Test]
        public void TestingPow()
        {
            double expected = 256;
            Assert.AreEqual(expected, MiniMath.MiniMath.Pow(2,8));
        }
        
        [Test]
        public void TestingSqrt()
        {
            double expected = 5.09;
            Assert.AreEqual(expected, MiniMath.MiniMath.Sqrt(26),0.01);
        }
        
        [Test]
        public void TestingRoot()
        {
            double expected = 4.64;
            Assert.AreEqual(expected, MiniMath.MiniMath.Root(100,3),0.01);
        }
        
        [Test]
        public void TestingAbs()
        {
            double expected = 200;
            Assert.AreEqual(expected, MiniMath.MiniMath.Abs(-200));
        }
        
        [Test]
        public void TestingFactorial()
        {
            double expected = 24;
            Assert.AreEqual(expected, MiniMath.MiniMath.Factorial(4));
        }
        
        [Test]
        public void TestingGetPi()
        {
            double expected = 3.14;
            Assert.AreEqual(expected, MiniMath.MiniMath.GetPi(),0.1);
        }
        
        [Test]
        public void TestingGetPiRand()
        {
            double expected = 3.14;
            Assert.AreEqual(expected, MiniMath.MiniMath.GetPiRand(5),0.2);
        }
        
        [Test]
        public void TestingAreaTriangle()
        {
            double expected = 6;
            Assert.AreEqual(expected, MiniMath.MiniMath.AreaTriangle(3,4,5));
        }
        
        [Test]
        public void TestingPerimeter()
        {
            double expected = 15;
            Assert.AreEqual(expected, MiniMath.MiniMath.Perimeter(5,5,5));
        }
        
        [Test]
        public void TestingPVolume3d()
        {
            double expected = 125;
            Assert.AreEqual(expected, MiniMath.MiniMath.Volume3d(5,5,5));
        }
        
        [Test]
        public void TestingPGetE()
        {
            double expected = 2.71;
            Assert.AreEqual(expected, MiniMath.MiniMath.GetE(),0.01);
        }
        
        

    }
}