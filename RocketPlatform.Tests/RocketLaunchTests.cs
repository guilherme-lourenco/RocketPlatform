using System;
using Xunit;
using RocketPlatform;
using RocketPlatform.Service;
using RocketPlatform.Enum;

namespace RocketPlatform.Tests
{
    public class RocketLaunchTests
    {
        [Fact]
        public void OutOfPlatformTest()
        {
            PlatformAvailabilityService service = new PlatformAvailabilityService(100, 10);

            string TestResult = service.CheckPlatformAvailability("Test1", 1, 1);

            Assert.Equal(PlatformResponses.OutOfPlatform, TestResult);

        }

        [Fact]
        public void OkTest()
        {
            PlatformAvailabilityService service = new PlatformAvailabilityService(100, 10);

            string TestResult = service.CheckPlatformAvailability("Test2", 5, 5);

            Assert.Equal(PlatformResponses.Ok, TestResult);
        }

        [Fact]
        public void ClashTest()
        {
            PlatformAvailabilityService service = new PlatformAvailabilityService(100, 10);

            service.CheckPlatformAvailability("Test1", 5, 5);

            string TestResult = service.CheckPlatformAvailability("Test2", 6, 5);

            Assert.Equal(PlatformResponses.Clash, TestResult);
        }
    }
}
