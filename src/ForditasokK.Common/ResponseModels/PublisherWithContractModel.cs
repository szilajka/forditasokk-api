using ForditasokK.Common.ResponseModels.Channels;
using System;

namespace ForditasokK.Common.ResponseModels
{
    public class PublisherWithContractModel : HistoryInformationsModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public byte[] Logo { get; set; }
        public PublisherChannelResponseModel[] PublisherChannels { get; set; }
        public DateTime ContractStart { get; set; }
        public DateTime? ContractEnd { get; set; }
    }
}
