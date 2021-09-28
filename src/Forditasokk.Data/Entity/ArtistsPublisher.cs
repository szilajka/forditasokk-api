using System;

namespace Forditasokk.Data.Entity
{
    public class ArtistsPublisher : ModificationDateEntity
    {
        public DateTime ContractStart { get; set; }
        public DateTime? ContractEnd { get; set; }
        public long ArtistId { get; set; }
        public Artist Artist { get; set; }
        public long PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
