using System.Text;
using Jackett.Common.Models.IndexerConfig;
using Jackett.Common.Services.Interfaces;
using Jackett.Common.Utils.Clients;
using NLog;

namespace Jackett.Common.Indexers
{
    public abstract class IndexerBase : BaseWebIndexer
    {
        public abstract override string Id { get; }
        public abstract override string Name { get; }
        public abstract override string Description { get; }
        public abstract override string SiteLink { get; protected set; }
        public override Encoding Encoding => Encoding.UTF8;
        public abstract override string Language { get; }
        public abstract override string Type { get; }

        protected IndexerBase(IIndexerConfigurationService configService, WebClient client, Logger logger, ConfigurationData configData, IProtectionService p, ICacheService cacheService, string downloadBase = null)
            : base(configService, client, logger, configData, p, cacheService, downloadBase)
        {
        }

        protected IndexerBase(IIndexerConfigurationService configService, WebClient client, Logger logger, IProtectionService p, ICacheService cacheService)
            : base(configService, client, logger, p, cacheService)
        {
        }
    }
}
