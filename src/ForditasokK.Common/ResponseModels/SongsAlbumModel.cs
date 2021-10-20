using System;

namespace ForditasokK.Common.ResponseModels
{
    public class SongsAlbumModel : HistoryInformationsModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte[] Cover { get; set; }
        public long ArtistId { get; set; }
    }
}
