using System;
using Xunit;
using BabysitterKata;

namespace BabysitterTests
{
    public class BabysitterTests
    {
        Babysitter babysitter = new Babysitter();
        [Fact]
        public void WhenPassingInFiveAndTenReturnFive()
        {
            Assert.Equal("5",babysitter.CalculateDifferenceBetweenTwoHours("5PM","10PM"));
        }

        [Fact]
        public void WhenPassingInSevenAndTwelveReturnFive()
        {
            Assert.Equal("5", babysitter.CalculateDifferenceBetweenTwoHours("7PM","12AM"));
        }

        [Fact]
        public void WhenPassingInSevenAndThreeReturnEight()
        {
            Assert.Equal("8", babysitter.CalculateDifferenceBetweenTwoHours("7PM", "3AM"));
        }

        [Fact]
        public void CalculatePayWhenPassingInTwoNumbersAndAFamily()
        {
            Assert.Equal("45", babysitter.CalculatePay("8PM","11PM","A"));
        }

        [Fact]
        public void CalulatePayWhenWorkingFiveToTenForFamilyB()
        {
            Assert.Equal("60", babysitter.CalculatePay("5PM", "10PM", "B"));
        }
    }
}
