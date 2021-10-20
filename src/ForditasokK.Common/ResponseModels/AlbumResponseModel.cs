using System;

namespace ForditasokK.Common.ResponseModels
{
    public class AlbumResponseModel : HistoryInformationsModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte[] Cover { get; set; }
        public AlbumsArtistModel Artist { get; set; }
        public ArtistsSongModel[] Songs { get; set; }
    }
}
