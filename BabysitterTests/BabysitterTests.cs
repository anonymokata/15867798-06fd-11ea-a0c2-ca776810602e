using System;
using Xunit;
using BabysitterKata;

namespace BabysitterTests
{
    public class BabysitterTests
    {
        [Fact]
        public void WhenPassingInFiveAndTenReturnFive()
        {
            Babysitter babysitter = new Babysitter();
            Assert.Equal("5",babysitter.CalculateDifferenceBetweenTwoHours("5PM","10PM"));
        }

        [Fact]
        public void WhenPassingInSevenAndTwelveReturnFive()
        {
            Babysitter babysitter = new Babysitter();
            Assert.Equal("5", babysitter.CalculateDifferenceBetweenTwoHours("7PM","12AM"));
        }

        [Fact]
        public void WhenPassingInSevenAndThreeReturnEight()
        {
            Babysitter babysitter = new Babysitter();
            Assert.Equal("8", babysitter.CalculateDifferenceBetweenTwoHours("7PM", "3AM"));
        }
    }
}
