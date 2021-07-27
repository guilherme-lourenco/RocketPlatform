using RocketPlatform.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketPlatform.Models
{
    public class MapAsset
    {

        public string Name { get; set; }
        public AssetType Type { get; set; }
        public int Size { get; set; }
        public int StartX { get; set; }
        public int StartY { get; set; }
    }
}
