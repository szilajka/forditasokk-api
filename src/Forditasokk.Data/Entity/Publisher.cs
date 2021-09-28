using System.Collections.Generic;

namespace Forditasokk.Data.Entity
{
    public class Publisher : BaseEntity
    {
        public string Name { get; set; }
        public string LogoPath { get; set; }
        public IList<PublisherChannel> Channels { get; set; }
        public IList<ArtistsPublisher> Artists { get; set; }
    }
}
