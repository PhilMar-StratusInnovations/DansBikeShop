using DansBikeShop.Core.Common.Enums;
using DansBikeShop.Core.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DansBikeShop.Core.Business.Interfaces
{
    public interface IBikeInventoryManager
    {
        BikeModel GetBikeAsync(long ID);

        BikeModel AddBikeAsync(BikeModel bikeModel);

        BikeModel SaveBikeAsync(BikeModel bikeModel);

        bool DeleteBikeAsync(BikeModel bikeModel);
    }

    public interface IBikeInventoryManagerAdvanced
    {
        IEnumerable<BikeModel> FindBikes(string brand, string model, string subModel, string partialSerialNumber,
            Size? size, int? yearStart, int? yearEnd, DateTime? dateAcquiredStart, DateTime? dateAcquiredEnd,
            decimal? basePriceLow, decimal? basePriceHigh);
    }
}
