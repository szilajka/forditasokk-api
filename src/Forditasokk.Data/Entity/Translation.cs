namespace Forditasokk.Data.Entity
{
    public class Translation : BaseEntity
    {
        public string Title { get; set; }
        public string Lyrics { get; set; }
        public string TranslatorId { get; set; }
        public long SongId { get; set; }
        public Song Song { get; set; }
    }
}
