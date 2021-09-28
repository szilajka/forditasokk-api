namespace Forditasokk.Data.Entity
{
    public class PublisherChannel : Channel
    {
        public long PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
