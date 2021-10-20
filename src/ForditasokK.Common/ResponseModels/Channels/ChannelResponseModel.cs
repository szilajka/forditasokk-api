using Forditasokk.Data.Enum;

namespace ForditasokK.Common.ResponseModels.Channels
{
    public class ChannelResponseModel : HistoryInformationsModel
    {
        public long Id { get; set; }
        public ChannelTypes ChannelType { get; set; }
        public string Link { get; set; }
    }
}
