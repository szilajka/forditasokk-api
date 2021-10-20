using ForditasokK.Common.ResponseModels.Channels;

namespace ForditasokK.Common.ResponseModels
{
    public class SongResponseModel : HistoryInformationsModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Lyrics { get; set; }
        public SongsAlbumModel Album { get; set; }
        public SongChannelResponseModel[] SongChannels { get; set; }
        public ArtistSongFeatureModel[] Artists { get; set; }
        public SongsTranslationModel[] Translations { get; set; }
    }
}
