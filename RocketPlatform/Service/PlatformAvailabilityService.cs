using System;
using RocketPlatform.Enum;
using RocketPlatform.Models;

namespace RocketPlatform.Service
{
    public class PlatformAvailabilityService
    {
        public MapAsset Platform;
        public MapAsset LandingArea;
        public MapAsset LastRocket;

        public PlatformAvailabilityService(int MapSize = 100, int PlatformSize = 10)
        {
            Platform = new MapAsset()
            {
                Name = "Platform1",
                Size = PlatformSize,
                Type = Enum.AssetType.RocketPlatform,
                StartX = 5,
                StartY = 5
            };

            LandingArea = new MapAsset()
            {
                Name = "LandingArea",
                Size = MapSize,
                Type = Enum.AssetType.RocketPlatform,
                StartX = 0,
                StartY = 0
            };

        }

        public string CheckPlatformAvailability(string RocketName, int PositionX, int PositionY)
        {
            MapAsset CurrentRocket = new MapAsset()
            {
                Name = RocketName,
                Size = 1,
                Type = Enum.AssetType.Rocket,
                StartX = PositionX,
                StartY = PositionY
            };

            string PlatformAvailability = PlatformResponses.OutOfPlatform;

            if (CurrentRocket.StartX >= Platform.StartX && CurrentRocket.StartX <= (Platform.StartX + Platform.Size) && CurrentRocket.StartY >= Platform.StartY  && CurrentRocket.StartY <= (Platform.StartY + Platform.Size))
            {
                PlatformAvailability = PlatformResponses.Ok;
            }

            if (LastRocket != null)
            {
                if (Math.Abs(CurrentRocket.StartX - LastRocket.StartX) <= 1 || Math.Abs(CurrentRocket.StartY - LastRocket.StartY) <= 1)
                {
                    PlatformAvailability = PlatformResponses.Clash;
                }
            }

            LastRocket = CurrentRocket;
            return PlatformAvailability;
        }
    }
}
