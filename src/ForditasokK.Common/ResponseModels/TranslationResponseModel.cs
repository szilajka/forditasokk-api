namespace ForditasokK.Common.ResponseModels
{
    public class TranslationResponseModel : HistoryInformationsModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Lyrics { get; set; }
        public ArtistsSongModel Song { get; set; }
        public string TranslatorId { get; set; }
    }
}
