namespace ForditasokK.Common.ResponseModels
{
    public class SongsTranslationModel : HistoryInformationsModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Lyrics { get; set; }
        public long SongId { get; set; }
        public string TranslatorId { get; set; }
    }
}
