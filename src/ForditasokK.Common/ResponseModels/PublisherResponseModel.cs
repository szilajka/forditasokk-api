using ForditasokK.Common.ResponseModels.Channels;

namespace ForditasokK.Common.ResponseModels
{
    public class PublisherResponseModel : HistoryInformationsModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public byte[] Logo { get; set; }
        public PublisherChannelResponseModel[] PublisherChannels { get; set; }
        public ArtistWithContractModel[] Artists { get; set; }
    }
}
