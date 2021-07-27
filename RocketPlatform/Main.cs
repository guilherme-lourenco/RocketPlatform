using RocketPlatform.Enum;
using RocketPlatform.Models;
using RocketPlatform.Service;
using System;

namespace RocketPlatform
{
    public class Main
    {
        public Main()
        {
            PlatformAvailabilityService service = new PlatformAvailabilityService(100, 10);
          
        }
      
    }
}
