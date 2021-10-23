using ForditasokK.Common.ResponseModels.Channels;

namespace ForditasokK.Common.ResponseModels.BaseModels
{
    public class SongBaseResponseModel : HistoryInformationsModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Lyrics { get; set; }
        public SongChannelResponseModel[] SongChannels { get; set; }
        public ArtistSongFeatureModel[] Artists { get; set; }
    }
}