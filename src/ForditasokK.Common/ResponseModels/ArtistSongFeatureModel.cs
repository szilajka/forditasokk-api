namespace ForditasokK.Common.ResponseModels
{
    public class ArtistSongFeatureModel : HistoryInformationsModel
    {
        public long SongId { get; set; }
        public long ArtistId { get; set; }
        public bool IsMainArtist { get; set; }
    }
}
