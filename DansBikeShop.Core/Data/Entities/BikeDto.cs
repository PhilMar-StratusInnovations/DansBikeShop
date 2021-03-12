using DansBikeShop.Core.Common.Enums;
using System;

namespace DansBikeShop.Core.Data.Entities
{
    public class BikeDto
    {
        public long ID { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string SubModel { get; set; }  // Color scheme, etc.

        public Size Size { get; set; }

        public int Year { get; set; }

        public string SerialNumber { get; set; }

        public DateTime DateAcquired { get; set; }

        public decimal BasePrice { get; set; }
    }
}
