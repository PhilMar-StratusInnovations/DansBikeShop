using Microsoft.Extensions.Logging;

namespace DansBikeShop.Core.Business.Base
{
    public abstract class BusinessManagerBase<TModel> 
    {
        protected ILogger Logger { get; }

        protected BusinessManagerBase(ILogger logger)
        {
            Logger = logger;
        }
    }
}
