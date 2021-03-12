using DansBikeShop.Core.Common.Enums;
using DansBikeShop.Core.Data.Entities;
using System;
using System.Collections.Generic;

namespace DansBikeShop.Core.Data.Interfaces
{
    /// <summary>
    /// Basic capabilities
    /// </summary>
    public interface IBikeRepository
    {
        BikeDto GetAsync(long bikeID);

        long AddAsync(BikeDto bikeDto);

        bool SaveAsync(BikeDto bikeDto);

        bool DeleteAsync(BikeDto bikeDto);
    }

    /// <summary>
    /// Advanced capabilities
    /// </summary>
    public interface IBikeRepositoryAdvanced
    {
        IEnumerable<BikeDto> FindBikes(string brand, string model, string subModel, string partialSerialNumber,
            Size? size, int? yearStart, int? yearEnd, DateTime? dateAcquiredStart, DateTime? dateAcquiredEnd,
            decimal? basePriceLow, decimal? basePriceHigh);
    }
}
