using System;
using Xunit;
using Standard_Vessel;
using speedInterface;
using System.IO;
using System.Collections.Generic;

namespace UnitTest
{
    public class UnitTest1
    {
       [Fact]
        public void GetNameTest()
        {
            Submarine testName = new Submarine("Test Submarine", "2004", "Submarine", new Speed(32), 100);

            string expectedName = "Test Submarine";
            string actualName = testName.GetName();

            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void GetYearBuiltTest()
        {
            Submarine testYear = new Submarine("Test Submarine", "2004", "Submarine", new Speed(32), maxDepth: 100);

            string expectedYear = "2004";
            string actualYear = testYear.GetYearBuilt();

            Assert.Equal(expectedYear, actualYear);
        }
        [Fact]
        public void FerryPassengersTest()
        {
            Ferry testPassangers = new Ferry("Test ferry", "2017", "Ferry", new Speed(56), passengers: 134);

            int expectedNumber = 134;

            int actualNumber = testPassangers.Passengers;

            Assert.Equal(expectedNumber, actualNumber);
        }
        [Fact]
        public void SubmarineMaxDepthTest()
        {
            Submarine testMaxDepth = new Submarine("Test Submarine", "2003", "Submarine", new Speed(10), maxDepth: 98);

            int expectedNumber = 98;

            int actualNumber = testMaxDepth.GetMaxDepth;

            Assert.Equal(expectedNumber, actualNumber);
        }
        [Fact]
        public void TugboatMaxForceTest()
        {
            Tugboat testMaxForce = new Tugboat("Test Tugboat", "2007", "Submarine", new Speed(78), maxForce: 3050);

            int expectedNumber = 3050;

            int actualNumber = testMaxForce.GetMaxForce;

            Assert.Equal(expectedNumber, actualNumber);
        }

        [Fact]
        public void DefaultSpeedTest()
        {
            Speed speedTest = new Speed(150);
            Speed speedTest2 = new Speed(275);

            string defaultNumber = speedTest.ToString();
            string defaultNumber2 = speedTest2.ToString();

            Assert.Equal("150.00kt/s", defaultNumber);
            Assert.Equal("275.00kt/s", defaultNumber2);
        }

        [Fact]
        public void MeterToSecondTest()
        {
            Speed speedTest = new Speed(150);
            Speed speedTest2 = new Speed(275);

            double expectedNumber = 77.17;
            double expectedNumber2 = 141.47;

            string actualNumber = speedTest.ToString("MS");
            string actualNumber2 = speedTest2.ToString("MS");

            Assert.Equal(expectedNumber.ToString() + "m/s", actualNumber);
            Assert.Equal(expectedNumber2.ToString() + "m/s", actualNumber2);
        }
    }
}

