using ForditasokK.Common.ResponseModels.Channels;
using System;

namespace ForditasokK.Common.ResponseModels.BaseModels
{
    public class ArtistBaseResponseModel : HistoryInformationsModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime DebutDate { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string FansName { get; set; }
        public ArtistChannelResponseModel[] ArtistChannels { get; set; }
    }
}
