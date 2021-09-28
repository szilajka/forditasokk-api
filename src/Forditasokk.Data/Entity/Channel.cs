using Forditasokk.Data.Enum;

namespace Forditasokk.Data.Entity
{
    public class Channel : BaseEntity
    {
        public ChannelTypes ChannelType { get; set; }
        public string Link { get; set; }
    }
}
